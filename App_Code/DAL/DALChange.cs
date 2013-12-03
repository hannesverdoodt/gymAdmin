using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALChange
/// </summary>
public class DALChange
{

    public GymCheckinDataContext dc = new GymCheckinDataContext();


    public void newFirst(tbl_user p_First)
    {
        // find row to update
        var query =
            from f in dc.tbl_users
            where f.user_tiwtter == p_First.user_tiwtter
            where f.user_password == p_First.user_password
            select f;


        List<tbl_user> x = query.ToList();

        //update

        foreach (tbl_user person in query)
        { 
            person.user_firstname = p_First.user_firstname;
        }

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




    public void newLast(tbl_user p_Last)
    {
        // find row to update
        var query =
            from f in dc.tbl_users
            where f.user_tiwtter == p_Last.user_tiwtter
            where f.user_password == p_Last.user_password
            select f;


        List<tbl_user> x = query.ToList();

        //update

        foreach (tbl_user person in query)
        {
            person.user_lastname = p_Last.user_lastname;
        }

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