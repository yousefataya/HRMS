using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.hallreservations
{
    public class HallReservationEntityFactory
    {

        public static HallReservationEntity Create(HallModel hallModel)
        {
            return new HallReservationEntity
            (

             notes: hallModel.Description,
             hallId: hallModel.HallId
            );
        }
    }
}
