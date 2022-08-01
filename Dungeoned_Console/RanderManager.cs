using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoned_Console
{
    public enum RanderLayer
    {
        None = 0,
        Scene,
        UI,
    }

    

    public class RanderManager
    {

    }

    public class UIRanderCanvas : IRanderCanvas
    {
        private IRanderEntity[][] m_randerEntities = null;
        public IRanderEntity[][] GetRanderEntities()
        {
            return m_randerEntities;
        }

        public void SetRanderEntities(uint x, uint y, IRanderEntity randerEntity)
        {

        }

        public RanderLayer GetRanderLayer()
        {
            return RanderLayer.UI;
        }
    }

    public interface IRanderCanvas
    {
        public IRanderEntity[][] GetRanderEntities();
        public void SetRanderEntities(uint x, uint y, IRanderEntity randerEntity);
        RanderLayer GetRanderLayer();
        
    }

    public interface IRanderEntity
    {
        char Show{ get; set; }
        uint X{ get; set; }
        uint Y{ get; set; }
    }


}
