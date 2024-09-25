using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEmoLINQGymSearch.Classes.cs
{ 
        public static class Repository
        {
            //Metod som skapar 15 träningspass av olika typ med olika instruktörer
            public static List<TrainingSession> GetTrainingSessionData()
            {
                //Skapar en lista med exempeldata för sökningen
                List<TrainingSession> trainingSessionList = new List<TrainingSession>();

                Instructor instructor1 = new Instructor();
                instructor1.Name = "Anna Ljungkvist";

                Instructor instructor2 = new Instructor();
                instructor2.Name = "Dennis Ibrahim";

                Instructor instructor3 = new Instructor();
                instructor3.Name = "Lisa Lind";

                TrainingSessionType sessionType1 = new TrainingSessionType();
                sessionType1.Name = "Spinning";

                TrainingSessionType sessionType2 = new TrainingSessionType();
                sessionType2.Name = "Bodypump";

                //Lägg in 15 olika pass på olika instruktörer
                for (int outerCounter = 0; outerCounter < 3; outerCounter++)
                {
                    for (int innerCounter = 1; innerCounter <= 5; innerCounter++)
                    {
                        TrainingSession session = new TrainingSession();
                        session.StartTime = DateTime.Now.AddDays(innerCounter);
                        session.EndTime = DateTime.Now.AddDays(innerCounter).AddHours(1);

                        //Varannat pass blir spinning eller bodypump
                        if (innerCounter % 2 == 0)
                            session.Type = sessionType1;
                        else
                            session.Type = sessionType2;

                        //Lägg in pass för alla 3 instruktörerna
                        if (outerCounter == 0)
                            session.Trainer = instructor1;
                        else if (outerCounter == 1)
                            session.Trainer = instructor2;
                        else
                            session.Trainer = instructor3;

                        trainingSessionList.Add(session);
                    }
                }

                return trainingSessionList;
            }
        }
    }
