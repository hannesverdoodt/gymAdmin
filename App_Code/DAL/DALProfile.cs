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

    public List<tbl_user> getURL(tbl_user gebruiker)
    {

        var query =
            from g in dc.tbl_users
            where g.user_tiwtter == gebruiker.user_tiwtter
            where g.user_password == gebruiker.user_password
            select g;

            return query.ToList();






        /*

          

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


    }



}