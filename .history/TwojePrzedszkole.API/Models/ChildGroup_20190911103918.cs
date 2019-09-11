using System.Collections.ObjectModel;

namespace TwojePrzedszkole.API.Models
{
    public class ChildGroup
    {
        public int Id { get; set; }
        public Collection<ChildGroupCategory> ChildGroupCategories { get; set; }
        public Collection<Child> AssignedChilds { get; set; }
    }
}