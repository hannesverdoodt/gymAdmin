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


    public void newFirst(tbl_user p_first)
    {
        dalchange.newFirst(p_first);
    }


    public void newLast(tbl_user p_last)
    {
        dalchange.newLast(p_last);
    }

	
}