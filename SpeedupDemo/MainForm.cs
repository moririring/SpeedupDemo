using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void DeepWork()
        {
            Thread.Sleep(50);
        }
        private void forButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                DeepWork();
            }
            MessageBox.Show("100回終わりました！");
        }
        private void parallelForButton_Click(object sender, EventArgs e)
        {
            Parallel.For(0, 100, i =>
            {
                DeepWork();
            });
            MessageBox.Show("100回終わりました！");
        }
        private void normalButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                DeepWork();
            }
            MessageBox.Show("100回終わりました！");
        }
        private async void threadButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    DeepWork();
                }
            });
            MessageBox.Show("100回終わりました！");
        }

        private async void buttonOffbutton_Click(object sender, EventArgs e)
        {
            buttonOffbutton.Enabled = false;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    DeepWork();
                }
            });
            buttonOffbutton.Enabled = true;
            MessageBox.Show("100回終わりました！");

        }

        private async void popupButton_Click(object sender, EventArgs e)
        {
            var form = new RunForm();
            this.AddOwnedForm(form);
            form.Show();
            popupButton.Enabled = false;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    DeepWork();
                }
            });
            form.Close();
            popupButton.Enabled = true;
            MessageBox.Show("100回終わりました！");

        }

        private async void progressButton_Click(object sender, EventArgs e)
        {
            var uiTask = TaskScheduler.FromCurrentSynchronizationContext();
            progressButton.Enabled = false;
            progress1ProgressBar.Value = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    DeepWork();
                    new Task(() => progress1ProgressBar.Value = i).Start(uiTask);
                }
            });
            progress1ProgressBar.Value = 100;
            progressButton.Enabled = true;
            MessageBox.Show("100回終わりました！");

        }

        private async void progressCancelButton_Click(object sender, EventArgs e)
        {
            var uiTask = TaskScheduler.FromCurrentSynchronizationContext();
            _cancelToken = new CancellationTokenSource();
            progressCancelButton.Enabled = false;
            progress2ProgressBar.Value = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    DeepWork();
                    if (_cancelToken.IsCancellationRequested) break;
                    new Task(() => progress2ProgressBar.Value = i).Start(uiTask);
                }
            });
            progressCancelButton.Enabled = true;
            if (!_cancelToken.IsCancellationRequested)
            {
                progress2ProgressBar.Value = 100;
                MessageBox.Show("100回終わりました！");
            }
            else
            {
                progress2ProgressBar.Value = 0;
            }
            _cancelToken.Dispose();

        }
        private CancellationTokenSource _cancelToken;
        private void cancelButton_Click(object sender, EventArgs e)
        {
            _cancelToken.Cancel();

        }
    }
}
