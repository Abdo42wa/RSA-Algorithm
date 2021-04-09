using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (pTxt.Text == string.Empty || qTxt.Text == string.Empty)
            {
                MessageBox.Show("P, Q, can't be empty !");
            }
            else
            {
                BigInteger p = BigInteger.Parse(pTxt.Text);
                BigInteger q = BigInteger.Parse(qTxt.Text);


                if (encryptTxt.Text == string.Empty)
                {
                    MessageBox.Show("There's no text to encrypt !");
                }
                else if (p == q)
                {
                    MessageBox.Show("Prime numbers cannot have same value !");
                }
                else if (HelperMethods.checkPrime(p) != true)
                {
                    MessageBox.Show("P must be prime number!");
                }
                else if (HelperMethods.checkPrime(q) != true)
                {
                    MessageBox.Show("Q must be prime number!");
                }

                else
                {

                    RSA_Algorithm rsaA = new RSA_Algorithm();
                    rsaA.rsaEncryption(encryptTxt.Text, p, q);
                    encryptedTxt.Text = rsaA.Encryption();
                    //(encryptTxt.Text, p, q);
                }
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (encryptTxt.Text == string.Empty)
            {
                MessageBox.Show("There's nothing to decrypt !");
            }
            else if (nTxt.Text == string.Empty)
            {
                MessageBox.Show("No value N inserted !");
            }
            else if (eTxt.Text == string.Empty)
            {
                MessageBox.Show("No value E inserted !");
            }
            else
            {

                string[] decText = (encryptTxt.Text).Split(' ');
                BigInteger[] encText = new BigInteger[decText.Length];

                for (int i = 0; i < decText.Length; i++)
                {
                    BigInteger temp = 0;
                    if (BigInteger.TryParse(decText[i], out temp))
                    {
                        if (temp != 0)
                        {
                            encText[i] = BigInteger.Parse(decText[i]);
                        }
                    }
                }
                BigInteger n = BigInteger.Parse(nTxt.Text);
                BigInteger ex = BigInteger.Parse(eTxt.Text); // Pervadinta į ex nes maišosi su EventArgs e

                RSA_Algorithm rsaA = new RSA_Algorithm();
                rsaA.rsaDecryption(encText, n, ex);
                decryptedTxt.Text = rsaA.Decryption();
            }
        }
    }
}
