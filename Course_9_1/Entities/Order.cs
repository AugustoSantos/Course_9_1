using Course_9_1.Entities.Enums;
using System;

namespace Course_9_1.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", "
                + Moment + ", "
                + Status;
        }
    }
}
