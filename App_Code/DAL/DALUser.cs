using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALUser
/// </summary>
public class DALUser
{
    GymCheckinDataContext db = new GymCheckinDataContext();
	
         
     public void update(tbl_user d)
    {
        db.tbl_users.InsertOnSubmit(d);
        db.SubmitChanges();
    }
     public IList<tbl_user> getAllUserAllowed()
     {
         var result = from u in db.tbl_users where u.user_allowed == 1 select u;

         return result.ToList();

     }
     public IList<tbl_user> getAllUsers()
     {
         var result = from u in db.tbl_users where u.user_allowed == 0 select u;

         return result.ToList();

     }
}