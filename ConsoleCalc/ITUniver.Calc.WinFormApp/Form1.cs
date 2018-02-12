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
            cbOperation.Items.Clear();
            var operations = calc.GetOpers();
            cbOperation.DataSource = operations;
            /*  var superOperation = operations.OfType<SuperOperation>(); //.Where(o => o is SuperOperation);

              cbOperation.Items.AddRange(superOperation.Select(s => s.OwnerName).ToArray());
              cbOperation.Items.AddRange(
                  operations
                  .Except(superOperation)
                  .Select(s => s.Name)
                  .ToArray()
                  );*/
            btnCalc.Enabled = false;
            #endregion

            #region Загрузка истории
            lbHistory.Items.AddRange(MyHelper.GetAll());
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

            Calculate();
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastOperation = cbOperation.SelectedItem as IOperation;
            tbInput.Enabled = true;
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
            btnCalc.Enabled = !string.IsNullOrWhiteSpace(tbInput.Text);
            /*   var timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(btnCalc_Click);
                timer.Enabled = true;*/


            // timer.Dispose();

        }
        private void Calculate()
        {

            if (lastOperation == null)
                return;

            // получить данные
            var args = tbInput.Text
                .Trim()
                .Split(' ')
                .Select(str => Convert.ToDouble(str))
                .ToArray();

            // вычислить результат
            var result = lastOperation.Exec(args);

            // показать результат
            tbResult.Text = $"{result}";

            // добавить в историю в БД
            MyHelper.AddToHistory(lastOperation.Name, args, result);
            // добавить в историю на форму
            lbHistory.Items.Clear();
            lbHistory.Items.AddRange(MyHelper.GetAll());
        }

    }
}

