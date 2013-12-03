using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for userDAL
/// </summary>
public class userDAL
{
    private GymCheckinDataContext dc = new GymCheckinDataContext();

	public void insert(tbl_user user){
        dc.tbl_users.InsertOnSubmit(user);
        dc.SubmitChanges();
    }
}