﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02_wf
{
    public partial class Form1 : Form
    {
        RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);

        public Form1()
        {
            InitializeComponent();

            InitValues();
            InitMessage();           
        }   

        private void InitMessage()
        {
            string caption = "Приветствуем! :)";
            string message = "В данной программе вы можете изменять некоторые значения полей в реестре вашей ОС Windows." + Environment.NewLine +
                "Так же вы можете ознакомиться с описанием каждого изменяемого поля по нажатию на кнопку \"Получить подробную информацию\"" + Environment.NewLine +
                "По нажатию на кнопку \"Обновить\", а так же каждый раз при запуске программы будут обновляться текущие значения полей в реестре.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = textBox1.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\","");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox19.Text, Convert.ToInt32(numericUpDown1.Text), RegistryValueKind.DWord);

            newKey.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = textBox4.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox30.Text, Convert.ToInt32(numericUpDown2.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var path = textBox6.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox29.Text, Convert.ToInt32(numericUpDown3.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var path = textBox8.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox28.Text, Convert.ToInt32(numericUpDown4.Text), RegistryValueKind.String);

            newKey.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var path = textBox10.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox27.Text, Convert.ToInt32(checkBox2.Checked == true ? 1 : 0), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var path = textBox18.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox26.Text, Convert.ToInt32(checkBox5.Checked == true ? 1 : 0), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var path = textBox16.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox25.Text, Convert.ToInt32(checkBox1.Checked == true ? 1 : 0), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var path = textBox14.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox24.Text, Convert.ToInt32(checkBox4.Checked == true ? 1 : 0), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var path = textBox12.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox23.Text, Convert.ToInt32(checkBox3.Checked == true ? 1 : 0), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var path = textBox22.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);

            newKey.SetValue(textBox20.Text, Convert.ToInt32(numericUpDown5.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра PasswordExpiryWarning";
            string message = "Параметр PasswordExpiryWarning описывает количество дней за которое пользователь будет уведомлен о том что необходимо сменить пароль от его учетной записи, перед тем как истечет срок действия уже существующего пароля.";

            ShowDescriptionMessageBox(caption, message);
        }   

        private void button12_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра EnableForcedLogoff";
            string message = "Параметр EnableForcedLogoff описывает количество времени (в часах) по истечению которого пользователь будет отключен.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра MaximumPasswordAge";
            string message = "Параметр MaximumPasswordAge описывает максимальное время (в сутках) в течении которого действителен установленный пользователем пароль для его учетной записи.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра CachedLogonsCount";
            string message = "Параметр CachedLogonsCount описывает количество предыдущих подключений в случае отсутствия доступа к контроллеру домена.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра AuditBaseObjects";
            string message = "Параметр AuditBaseObjects описывает аудит доступа к глобальным системным объектам.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра ShutDownWithoutLogon";
            string message = "Параметр ShutDownWithoutLogon описывает возможность выключения системы без входа в учетную запись.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра SealSecureChannel";
            string message = "Параметр SealSecureChannel описывает возможность шифрования данных для безопасных каналов.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра EnableVirtualization";
            string message = "Параметр EnableVirtualization описывает возможность виртуализации в месте размещения пользователя при сбоях записи в файл или реестр.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра EnableSecuritySignature";
            string message = "Параметр EnableSecuritySignature описывает возможность использования цифровой подписи.";

            ShowDescriptionMessageBox(caption, message);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string caption = "Описание параметра NtlmMinServerSec";
            string message = "Параметр NtlmMinServerSec описывает минимальную сеансовую безопсность для серверов на базе NTLM SSP (в том числе безопасный RPC).";

            ShowDescriptionMessageBox(caption, message);
        }

        private void ShowDescriptionMessageBox(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InitValues(false);
        }

        private void InitValues(bool init = true)
        {
            var path = textBox1.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            var newKey = key.OpenSubKey(path, true);
            numericUpDown1.Text = newKey.GetValue(textBox19.Text).ToString();

            path = textBox4.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            numericUpDown2.Text = newKey.GetValue(textBox30.Text).ToString();

            path = textBox6.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            numericUpDown3.Text = newKey.GetValue(textBox29.Text).ToString();

            path = textBox8.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            numericUpDown4.Text = newKey.GetValue(textBox28.Text).ToString();

            //////////////////////////////////////////////////////////////////////////////////

            path = textBox10.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            checkBox2.Checked = newKey.GetValue(textBox27.Text).ToString() == "1" ? true : false;

            path = textBox18.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            checkBox5.Checked = newKey.GetValue(textBox26.Text).ToString() == "1" ? true : false;

            path = textBox16.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            checkBox1.Checked = newKey.GetValue(textBox25.Text).ToString() == "1" ? true : false;

            path = textBox14.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            checkBox4.Checked = newKey.GetValue(textBox24.Text).ToString() == "1" ? true : false;

            path = textBox12.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            checkBox3.Checked = newKey.GetValue(textBox23.Text).ToString() == "1" ? true : false;

            //////////////////////////////////////////////////////////////////////////////////

            path = textBox22.Text.Replace("\r\n", "").Replace("HKEY_LOCAL_MACHINE\\", "");
            newKey = key.OpenSubKey(path, true);
            numericUpDown5.Text = newKey.GetValue(textBox20.Text).ToString();

            if (!init)
            {
                string caption = "Параметры";
                string message = "Значения всех параметров были успешно обновлены.";

                ShowDescriptionMessageBox(caption, message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InitMessage();
        }
    }
}
