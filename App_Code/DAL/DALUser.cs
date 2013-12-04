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
        var recordToUpdate = (from user in db.tbl_users where d.user_id
                                  == user.user_id select user).Single();
        recordToUpdate.user_allowed = 1;
       
        db.SubmitChanges();
     }

     public void delete(tbl_user d)
     {
         var user = (from u in db.tbl_users
                     where u.user_id == d.user_id
                     select u).Single();
         db.tbl_users.DeleteOnSubmit(user);
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