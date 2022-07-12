using BlogProject_5175_06062022.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? RemovedDate { get; set; }

        private Statu _statu=Statu.Passive;

        public Statu Statu
        {
            get { return _statu; }
            set { _statu = value; }
        }

    }
}
