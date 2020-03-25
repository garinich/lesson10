using System;

namespace CarStorage
{
    public class Insurance
    {
        public Insurance(DateTime creationDate, DateTime expirationDate, string ownerFullName)
        {
            CreationDate = creationDate;
            ExpirationDate = expirationDate;
            OwnerFullName = ownerFullName;
        }
        
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string OwnerFullName { get; set; }
    }
}