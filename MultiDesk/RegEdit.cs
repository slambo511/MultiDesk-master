using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MultiDesk
{
    class RegEdit
    {
        public bool _showError = false;
        public string _subKey = "SOFTWARE\\" + Application.ProductName;
        public RegistryKey _baseRegsKey = Registry.LocalMachine;

        public string ReadKey(string KeyName)
        {
            RegistryKey rk = _baseRegsKey;
            RegistryKey sk1 = rk.OpenSubKey(_subKey);
            if (sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return (string) sk1.GetValue(KeyName.ToUpper());
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }

        }

        public bool WriteKey(string KeyName, object Value)
        {
            try
            {
                RegistryKey rk = _baseRegsKey;
                RegistryKey sk1 = rk.CreateSubKey(_subKey);
                sk1.SetValue(KeyName.ToUpper(), Value);
                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }

        public bool DeleteKey(string KeyName)
        {
            try
            {
                RegistryKey rk = _baseRegsKey;
                RegistryKey sk1 = rk.CreateSubKey(_subKey);
                if (sk1 == null)
                {
                    return true;
                }
                else
                {
                    sk1.DeleteValue(KeyName);
                }
                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, "Deleting subkey " + _subKey);
                return false;
            }
        }

        public bool DeleteSubKeyTree()
        {
            try
            {
                RegistryKey rk = _baseRegsKey;
                RegistryKey sk1 = rk.OpenSubKey(_subKey);
                if (sk1 != null)
                {
                    rk.DeleteSubKeyTree(_subKey);
                }
                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, "Deleting subkey " + _subKey);
                return false;
            }
        }

        public int SubKeyCount()
        {
            try
            {
                RegistryKey rk = _baseRegsKey;
                RegistryKey sk1 = rk.OpenSubKey(_subKey);
                if (sk1 != null)
                {
                    return sk1.SubKeyCount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, "Retrieving subkeys of " + _subKey);
                return 0;
            }
        }

        public int ValueCount()
        {
            try
            {
                RegistryKey rk = _baseRegsKey;
                RegistryKey sk1 = rk.OpenSubKey(_subKey);
                if (sk1 != null)
                {
                    return sk1.ValueCount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, "Retrieving keys of " + _subKey);
                return 0;
            }
        }

        private void ShowErrorMessage(Exception ex, string Title)
        {
            if (_showError)
            {
                Debug.WriteLine(ex.Message + " " + Title);
            }
        }

    }
}
