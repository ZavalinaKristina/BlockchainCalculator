using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleCalc;
using ITUniver.Calc.Core.Interface;


namespace ITUniver.Calc.WinFormApp
{
    public partial class Form1 : Form
    {
        private ConsoleCalc.Calc calc { get; set; }
        private IOperation lastOperation { get; set; }


        public Form1()
        {
            InitializeComponent();

            #region Загрузка операций
            calc = new ConsoleCalc.Calc();
            // var operations = calc.GetOperNames();
            // cbOperation.Items.Clear();
            //cbOperation.Items.AddRange(operations);
            cbOperation.DataSource = calc.GetOpers();
            cbOperation.DisplayMember = "Name";
            #endregion


        }

        private void btnLuck_Click(object sender, EventArgs e)
        {
            cbOperation.SelectedIndex = new Random().Next(0, cbOperation.Items.Count);
            tbResult.Text = "Успех!";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tbInput.Focus();
            tbInput_Click(sender, e);
            //получить операцию
            if (lastOperation == null)
                return;

            //получить данные
            var args = tbInput.Text
                .Trim()
                .Split(' ')
                .Select(str => Convert.ToDouble(str))
                .ToArray();

            //вычислить результат
            var result = lastOperation.Exec(args);
            //показать результат
            tbResult.Text = $"{result}";
            //добавили историю в бд
            MyHelper.AddToHistory(lastOperation.Name, args, result);
            //добавили историю на форму
            lbHistory.Items.Add(MyHelper.GetAll());
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastOperation = cbOperation.SelectedItem as IOperation;
        }

        private void tbInput_Click(object sender, EventArgs e)
        {
            tbInput.SelectAll();
        }

        private void tbInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalc_Click(sender, e);
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

            /*    var timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(btnCalc_Click);
                timer.Enabled = true;*/

            //timer.Dispose();

        }


    }
}

