using System;
using System.Collections;
using System.Globalization;

namespace Authentication
{
	public sealed class LoginManager
	{
	    private Hashtable m_users = new Hashtable();

	    public bool IsLoginOK(string user, string password)
	    {
	        try
	        {
		        //deal with network
		        //deal with network
		        //deal with network
		        Logger.Write("blah");
	        }
	        catch (LoggerException e)
	        {
	            WebService.Write(DateTime.Now.ToString(CultureInfo.InvariantCulture) + ": " + e.Message + " " + Environment.MachineName + ".");
	        }
	        if (m_users[user] != null &&
	            (string) m_users[user] == password)
	        {
	            return true;
	        }
	        return false;
	    }

	    public void AddUser(string user, string password)
	    {
	        m_users[user] = password;
	    }

	    public void ChangePass(string user, string oldPass, string newPassword)
		{
			m_users[user]= newPassword;
		}
	}
}
