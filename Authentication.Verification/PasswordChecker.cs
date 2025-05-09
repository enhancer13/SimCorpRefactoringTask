﻿using System.Text.RegularExpressions;

namespace Authentication.Verification
{
    public class PasswordChecker
    {
        public bool Check(string password)
        {
            if (password.Length > 0 && password.Length < 17)
            {
                if (Regex.IsMatch(password,"[a-z]") && Regex.IsMatch(password,"[A-Z]"))
                {
                    if (Regex.IsMatch(password,"0-9") 
                    && Regex.IsMatch(password, @"[!@#$%^&*()]"))
                    {
                        return true;
                    }                  
                }
            }
            return false;
        }
        
    }
}