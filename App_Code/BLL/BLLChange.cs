using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLChange
/// </summary>
public class BLLChange
{
    DALChange dalchange = new DALChange();

    // FIRSTNAME

    public void newFirst(tbl_user p_first)
    {
        dalchange.newFirst(p_first);
    }


    // LASTNAME

    public void newLast(tbl_user p_last)
    {
        dalchange.newLast(p_last);
    }


    // TWITTER

    public void newPass(tbl_user p_pass)
    {
        dalchange.newPass(p_pass);
    }

	
}