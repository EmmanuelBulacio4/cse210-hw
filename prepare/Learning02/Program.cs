using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._compani = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //De esta manera llamo el metodo de la clase. En este caso
        //es mostrar la linea con el cargo, empresa, año de inicio y final.
        //job1.Display();

        Job job2 = new Job();
        job2._compani = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2017;
        job2._endYear = 2018;
        //job2.Display();

        Resume _myResume = new Resume();
        _myResume._personName = "Emmanuel Bulacio";

        //No estaba agregando los trabajaos a la lista!!!
        _myResume._jobsList.Add(job1);
        _myResume._jobsList.Add(job2);

        //Ahora si puedo mostrar la lista de trabajos.
        _myResume.DisplayJobs();

    }
}