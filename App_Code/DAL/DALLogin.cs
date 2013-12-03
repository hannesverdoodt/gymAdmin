using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALLogin
/// </summary>
public class DALLogin
{

    public GymCheckinDataContext dc = new GymCheckinDataContext();

    public List<tbl_user> getUser(tbl_user user)
    {
        // Query to find the user
        var query =
           from u in dc.tbl_users
           where u.user_tiwtter == user.user_tiwtter
           where u.user_password == user.user_password
           select u;

        List<tbl_user> x = query.ToList();

        if (x.Count == 0)
        {
            throw new Exception("Twittername or Password is wrong");
        }
        else
        {
            return query.ToList();

        }
      }

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