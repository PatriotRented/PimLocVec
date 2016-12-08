﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pim.Patriot.DataAccess;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pim.Patriot.MDI
{
    /// <summary>
    /// Interaction logic for wpfLogin.xaml
    /// </summary>
    public partial class wpfLogin : System.Windows.Controls.UserControl
    {
        //private bool valor;
        frmLogin logHandle;

        public wpfLogin()
        {
            InitializeComponent();

        }

        public wpfLogin(frmLogin HWND)
        {
            InitializeComponent();
            logHandle = HWND;
            
            
        }

        private void txtUser_Click(object sender, RoutedEventArgs e)
        {
            txtUser.Text = "";
        }

        private void pboxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        public void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginAcess lg = new LoginAcess();
            Criptografia crip = new Criptografia(CryptProvider.RC2);
            crip.Key = txtUser.Text;
            string senhaCript = crip.Encrypt(pboxSenha.Password);

            bool valida = lg.validaLogin(txtUser.Text, senhaCript);

            if (valida == true)
            {
                logHandle.entralogin();             

            }
            else
            {
                System.Windows.MessageBox.Show("Usuário ou senha inválidos!!","erro",MessageBoxButton.OK);
            }
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }

        private void txtUser_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            txtUser.Text = "";
        }

        

        private void btnLogin_DragEnter(object sender, System.Windows.DragEventArgs e)
        {
            LoginAcess lg = new LoginAcess();
            Criptografia crip = new Criptografia(CryptProvider.RC2);
            crip.Key = txtUser.Text;
            string senhaCript = crip.Encrypt(pboxSenha.Password);

            bool valida = lg.validaLogin(txtUser.Text, senhaCript);

            if (valida == true)
            {
                logHandle.entralogin();

            }
            else
            {
                System.Windows.MessageBox.Show("Usuário ou senha inválidos!!", "erro", MessageBoxButton.OK);
              
            }
        }
    }
}
