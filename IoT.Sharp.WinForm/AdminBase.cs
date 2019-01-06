using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using IoT.Sharp.Sdk.CSharp;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT.Sharp.WinForm
{
    public class AdminBase<T>: DevExpress.XtraBars.Ribbon.RibbonForm
    {
        GridControl gridControl;
        GridView gridView;
        BindingSource modelBindingSource;
       
        public void InitializeGridView(GridView _gridView)
        {
            gridControl = _gridView?.GridControl;
            if (gridControl != null  && !gridControl.IsDisposed && !gridControl.IsDesignMode)
            {
                modelBindingSource = gridControl.DataSource as BindingSource;
                gridView = _gridView;
                gridView.InitNewRow += gridView_InitNewRow;
                gridView.RowUpdated += gridView_RowUpdated;
                gridView.RowDeleted += gridView_RowDeleted;
                gridView.EditFormPrepared += gridView_EditFormPrepared;
                gridControl.Disposed += _gridControl_Disposed;
                gridControl.Load += GridControl_Load;
            }
        }

        private void GridControl_Load(object sender, EventArgs e)
        {
            DoRefresh();
        }

        private void _gridControl_Disposed(object sender, EventArgs e)
        {
            cts?.Cancel(false);
        }

        private CancellationTokenSource cts;

      
        public virtual Task<ICollection<T>> GetAllAsync(CancellationToken token)
        {
            return Task.FromResult<ICollection<T>>(null);
        }
     
        public async void  DoRefresh()
        {
            gridView.ShowLoadingPanel();
            try
            {
                cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                modelBindingSource.DataSource = await GetAllAsync(cts.Token);
            }
            catch (SwaggerException se)
            {
                XtraMessageBox.Show(se.ToResult().msg);
            }
            gridView.HideLoadingPanel();
        }


      
        public  void DoNew()
        {
            gridView.AddNewRow();
            gridView.ShowEditForm();
        }
       

        public void DoEdit()
        {
            gridView.ShowEditForm();
        }
       
        public void DoDelete()
        {
            if (XtraMessageBox.Show("是否确定删除所选数据", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView.DeleteSelectedRows();
            }
        }

        private Guid NewID = Guid.Empty;
        public virtual GridColumn ColumnKey { get; set; }

        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            NewID = Guid.NewGuid();
            gridView.SetRowCellValue(e.RowHandle, ColumnKey, NewID);
        }

        private void gridView_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
       
            var editor = e.Panel.Parent as Form;
            editor.StartPosition = FormStartPosition.CenterScreen;
    
        }

        public virtual Task<T> Post(T obj, CancellationToken token)
        {
            return Task.FromResult(obj);
        }

        public virtual Task<FileResponse> Put(T obj, CancellationToken token)
        {
            return Task.FromResult<FileResponse>(null);
        }

        private async void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is T obj)
                {
                    gridView.ShowLoadingPanel();
                    cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                    if (NewID != Guid.Empty)
                    {
                        var o = await Post(obj, cts.Token);
                        NewID = Guid.Empty;
                    }
                    else
                    {
                        await Put(obj, cts.Token);
                    }
                }
            }
            catch (SwaggerException se)
            {
                XtraMessageBox.Show(se.Message + Environment.NewLine + se.ToResult().msg);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            gridView.HideLoadingPanel();
        }

        public virtual Task<T> Delete(T obj, CancellationToken token)
        {
            return Task.FromResult<T>(obj);
        }

        private async void gridView_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            if (e.Row is T obj)
            {
                try
                {
                    gridView.ShowLoadingPanel();
                    cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                    await Delete(obj, cts.Token);
                }
                catch (SwaggerException se)
                {
                    XtraMessageBox.Show(se.Message + Environment.NewLine + se.ToResult().msg);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                gridView.HideLoadingPanel();
            }
        }

       
    }
}