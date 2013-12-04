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
    public void delete(tbl_user d)
    {
        DALusers.delete(d);
    }
   public void update(tbl_user d)
    {
        DALusers.update(d);
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