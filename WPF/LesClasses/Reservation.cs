using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class Reservation
    {
        private int numReservation;
        private int numAssurance;
        private int numClient;
        private DateTime dateReservation;
        private DateTime dateDebutReservation;
        private DateTime dateFinReservation;
        private decimal moantantReservation;
        private string forfaitKm;

        public int NumReservation { get => numReservation; set => numReservation = value; }
        public int NumAssurance { get => numAssurance; set => numAssurance = value; }
        public int NumClient { get => numClient; set => numClient = value; }
        public DateTime DateReservation { get => dateReservation; set => dateReservation = value; }
        public DateTime DateDebutReservation { get => dateDebutReservation; set => dateDebutReservation = value; }
        public DateTime DateFinReservation { get => dateFinReservation; set => dateFinReservation = value; }
        public decimal MoantantReservation { get => moantantReservation; set => moantantReservation = value; }
        public string ForfaitKm { get => forfaitKm; set => forfaitKm = value; }

        public Reservation(int numReservation, int numAssurance, int numClient, DateTime dateReservation, DateTime dateDebutReservation, DateTime dateFinReservation, decimal moantantReservation, string forfaitKm)
        {
            NumReservation = numReservation;
            NumAssurance = numAssurance;
            NumClient = numClient;
            DateReservation = dateReservation;
            DateDebutReservation = dateDebutReservation;
            DateFinReservation = dateFinReservation;
            MoantantReservation = moantantReservation;
            ForfaitKm = forfaitKm;
        }
    }
}
