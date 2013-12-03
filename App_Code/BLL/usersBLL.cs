using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for usersBLL
/// </summary>
public class usersBLL
{
    userDAL daluser = new userDAL();

    public void insert(tbl_user user)
    {
        
        daluser.insert(user);
    }
}