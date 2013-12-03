using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALProfile
/// </summary>
public class DALProfile
{

    public GymCheckinDataContext dc = new GymCheckinDataContext();

    public List<tbl_user> getContent(tbl_user gebruiker)
    {

        var query =
            from g in dc.tbl_users
            where g.user_tiwtter == gebruiker.user_tiwtter
            where g.user_password == gebruiker.user_password
            select g;
        return query.ToList();

    }



}