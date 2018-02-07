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

namespace ITUniver.Calc.WinFormApp
{
    public partial class Form1 : Form
    {
        private ConsoleCalc.Calc calc { get; set; }
        public Form1()
        {
            InitializeComponent();

            #region Загрузка операций
            calc = new ConsoleCalc.Calc();
            var operations = calc.GetOperNames();
            cbOperation.Items.Clear();
            //cbOperation.Items.AddRange(operations);
            cbOperation.DataSource = operations;
            #endregion
        }

        private void btnLuck_Click(object sender, EventArgs e)
        {
            cbOperation.SelectedIndex = new Random().Next(0, cbOperation.Items.Count);
            tbResult.Text = "Успех!";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //получить операцию
            var oper = $"{cbOperation.SelectedItem}";

            //получить данные
            var args = tbInput.Text
                .Trim()
                .Split(' ')
                .Select(str => Convert.ToDouble(str))
                .ToArray();

            //вычислить результат
            var result = calc.Exec(oper, args);
            //показать результат
            tbResult.Text = $"{result}";
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.ReadOnly = false;
        }

        private void tbInput_Leave(object sender, EventArgs e)
        {
            btnCalc.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInput.Clear();
            tbResult.Clear();
        }
    }
}
