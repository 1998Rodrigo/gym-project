using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.Entity;


namespace DAO
{
    public class RegistrationData
    {
        public bool SaveClient(RegistrationModel model)
        {
            bool result = false;
            try
            {
                using (var db = new GymProjectEntities())
                {
                    var registration = new Registration()
                    {
                        ID = model.Id,
                        FNAME = model.Fname,
                        LNAME = model.Lname,
                        AGE = model.Age,
                        EMAIL = model.Email,
                        BIRTHDAY = Convert.ToDateTime(model.BirthDate)
                    };
                    db.Registrations.Add(registration);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public bool UpdateClient(RegistrationModel model)
        {
            bool result = false;
            try
            {
                using (var db = new GymProjectEntities())
                {
                    var registration = new Registration() { };
                    db.Registrations.Attach(registration);
                    db.Entry(registration).State = EntityState.Modified;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public bool DeleteClient(RegistrationModel model)
        {
            bool result = false;
            try
            {
                using (var db = new GymProjectEntities())
                {
                    var registration = db.Registrations.Find((model.Id));
                    if(registration != null)
                    {
                        db.Registrations.Attach(registration);
                        db.Registrations.Remove(registration);
                        db.SaveChanges();
                        result = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
