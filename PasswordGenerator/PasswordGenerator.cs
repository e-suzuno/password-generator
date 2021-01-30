using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PasswordGenerator
{
    class PasswordGenerator
    {



        public string CreatePassword(int wordCount , List<int> useTypesList)
        {

            PasswordWordList passwordWordList = new PasswordWordList();

            passwordWordList.SetWordList(useTypesList);


            var WordList = passwordWordList.GetWordList();


            var Passwordsb = new System.Text.StringBuilder();
            for (int i = 1; i <= wordCount; i++)
            {

                Random r1 = new System.Random();
                int r2 = r1.Next(0, WordList.Length);

                string word =  WordList.Substring(r2, 1);

                Passwordsb.AppendLine(word);
            }

            return Passwordsb.ToString();


        }


    }
}
