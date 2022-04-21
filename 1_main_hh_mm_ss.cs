using System;
// using MySql.Data.MySqlClient;

/* Das Programm hh_mm_ss.exe ermittelt aus einer Sekundenzahl die Angabe in Stunden, Minuten, Sekunden.
 * Beispielaufruf:
 * hh_mm_ss 7300
*/

public class hh_mm_ss
{

    //=======================================================================================
    //
    // -- Main --
    //
    //=======================================================================================
    public static int Main(string[] args)
    {
        int param_count = args.Length;

        if (param_count != 1)
        {
            Console.WriteLine("Das Programm hh_mm_ss.exe ermittelt aus einer Sekundenzahl die Angabe in Stunden, Minuten, Sekunden.");
            Console.WriteLine("hh_mm_ss 7300");
        }
        else
        {
            string param1 = args[0];
            long time_secs = tools.string_to_long(param1);
            long time_hours = time_secs/3600;
            long time_minutes = (time_secs - 3600 * time_hours) / 60;

            Console.WriteLine("{0} Sekunden sind {1:00} Stunde(n), {2:00} Minute(n) und {3:00} Sekunde(n)", time_secs, time_hours, time_minutes, time_secs%60);
			// INFO 2022-04-21
            
        }

        return 1;

    } /*-------------------------------- end of Main ---------------------*/

} // end of class timediff


