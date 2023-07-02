
namespace PayrollSystem.Tools
{
    public class Validation
    {
        #region Method Validate Only Letters
        public static void OnlyLetters(KeyPressEventArgs key)
        {
            if (Char.IsLetter(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsSeparator(key.KeyChar))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
                MessageBox.Show("Only Letters");
            }
        }

        #endregion

        #region Method Validate Only Numbers
        public static void OnlyNumbers(KeyPressEventArgs key)
        {
            if (Char.IsDigit(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsSeparator(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
                MessageBox.Show("Only Numbers");
            }
        }

        #endregion

        #region Method Validate Numbers Decimals
        public static void NumbersDecimals(KeyPressEventArgs key)
        {
            if (Char.IsDigit(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsSeparator(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (key.KeyChar.ToString().Equals("."))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
                MessageBox.Show("Only Numbers or Numbers Decimals");
            }
        }

        #endregion

        #region Method Email
        public static void Email(KeyPressEventArgs key)
        {
            if (Char.IsLetter(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsDigit(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (key.KeyChar.ToString().Equals("."))
            {
                key.Handled = false;
            }
            else if (key.KeyChar.ToString().Equals("@"))
            {
                key.Handled = false;
            }
            else if (key.KeyChar.ToString().Equals("_"))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
                MessageBox.Show("Only Emails");
            }
        }

        #endregion

        #region Method Email
        public static void PassWord(KeyPressEventArgs key)
        {
            if (Char.IsSeparator(key.KeyChar))
            {
                key.Handled = true;
                MessageBox.Show("Without Space");
            }
            else
            {
                key.Handled = false;
            }
        }

        #endregion


    }
}
