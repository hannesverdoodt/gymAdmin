using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLLogin
/// </summary>
/// 

public class BLLLogin
{

   public DALLogin DALlogin = new DALLogin();

    public void getUser(tbl_user p_user)
    {
     
        DALlogin.getUser(p_user);
       
    }

}


/*

   DALticket DALticket = new DALticket();

    public void insert(BORRIAS_Ticket p_ticket)
    {
        String code = GenerateId();
        p_ticket.code = code;

        DALticket.insert(p_ticket);
    }

    public List<BORRIAS_Ticket> getAllUsed()
    {
        return DALticket.getAllUsed();
    }

    public void update(BORRIAS_Ticket p_ticket)
    {
        DALticket.update(p_ticket);
    }

    private string GenerateId()
    {
        long i = 1;
        foreach (byte b in Guid.NewGuid().ToByteArray())
        {
            i *= ((int)b + 1);
        }
        return string.Format("{0:x}", i - DateTime.Now.Ticks);
    }

*/