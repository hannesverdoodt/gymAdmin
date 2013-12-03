using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLUser
/// </summary>
public class BLLUser
{
    DALUser DALusers = new DALUser();

    public void update(tbl_user d)
    {
        if (d.user_allowed == 0)
        {

            d.user_allowed = d.user_allowed + 1;

           
            {
                throw new Exception("User is nu member van The Creativity Gym");
            }

            DALusers.update(d);
        }
        else
        {
            throw new Exception("User is niet gevonden");
        }
    }
    public IList<tbl_user> getAllUsers()
    {
        return DALusers.getAllUsers();
    }
    public IList<tbl_user> getAllUserAllowed()
    {
        return DALusers.getAllUserAllowed();
    }
}