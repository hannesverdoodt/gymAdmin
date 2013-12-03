using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLProfile
/// </summary>
public class BLLProfile
{

    DALProfile dalprofile = new DALProfile();

    public List<tbl_user> getContent(tbl_user gebruiker)
    {

        return dalprofile.getContent(gebruiker);
    
    }



}