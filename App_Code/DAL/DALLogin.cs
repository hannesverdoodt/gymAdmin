using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALLogin
/// </summary>
public class DALLogin
{

    /*
     public GymCheckinDataContext dc = new GymCheckinDataContext();

    public void getUser(tbl_user p_user)
    {
        // Query the database to find the user
        var query =
            from u in dc.tbl_users
            where u.user_tiwtter == p_user.user_tiwtter
            where u.user_password == p_user.user_password
            select u;
     try
        {
            List<tbl_user> x = query.ToList();
   
        // Check if user exists or doesn't exist

       
        if (x.Count > 0)
        {
      

            if (p_user.fk_function_id == 1)
            {
                throw new Exception("1");
            }
            else if (p_user.fk_function_id == 2)
            {
                throw new Exception("2");
            }
            else if (p_user.fk_function_id == 3)
            {
                throw new Exception("3");
               
            }
            else
            {
                throw new Exception("4");
            }
        }

        else
        {
           throw new Exception("Wrong Twittername or password");
        }

       

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
          
        }
        
        

    }*/

}
     
     

/*

    public void update(BORRIAS_Ticket p_ticket)
    {
        // Query the database for the row to be updated.
        var query =
            from t in dc.BORRIAS_Tickets
            where t.code == p_ticket.code
            select t;

        List<BORRIAS_Ticket> x = query.ToList();

        // Execute the query, and change the column values
        // you want to change.
        if (x.Count > 0)
        {
            foreach (BORRIAS_Ticket ticket in query)
            {
                ticket.used = 1;
            }
        }
        else
        {
            throw new Exception("Code niet gevonden");
        }
        // Submit the changes to the database.
        try
        {
            dc.SubmitChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            // Provide for exceptions.
        }

    } 
 */