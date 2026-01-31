using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
            return _reservationDal.GetListByFilter(x => x.AppUserId == id && x.Status=="Onay Bekliyor" );
        }

        public List<Reservation> GetListByFilter(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious( id);
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAccepted(id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public void Insert(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Reservation t)
        {
           _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public string? GetListWithReservationByWaitAccepted(int ıd)
        {
            throw new NotImplementedException();
        }
    }
}
