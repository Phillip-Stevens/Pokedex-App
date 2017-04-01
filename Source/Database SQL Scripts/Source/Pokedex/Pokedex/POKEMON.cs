using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class POKEMON
    {
        //// Variables for the class
        //decimal m_entry;
        //string m_name, m_description, m_element, m_elementtwo;
        //decimal m_generation;

        //// CONSTRUCTOR USED ONLY IF THE DATABASE BUG OCCURS DEMO PURPOSES ONLY!!!
        //public POKEMON(decimal entry, string name, string description, string element, string elementtwo, decimal generation)
        //{
        //    m_entry = entry;
        //    m_name = name;
        //    m_description = description;
        //    m_element = element;
        //    m_elementtwo = elementtwo;
        //    m_generation = generation;
        //}

        // Getters and Setters for local data if things go wrong
        #region
        //public decimal Entry
        //{
        //    get
        //    {
        //        return m_entry;
        //    }
        //}
        //public string Name
        //{
        //    get
        //    {
        //        return m_name;
        //    }
        //}
        //public string Description
        //{
        //    get
        //    {
        //        return m_description;
        //    }
        //}
        //public string Element
        //{
        //    get
        //    {
        //        return m_element;
        //    }
        //}
        //public string ElementTwo
        //{
        //    get
        //    {
        //        return m_elementtwo;
        //    }
        //}
        //public decimal Generation
        //{
        //    get
        //    {
        //        return m_generation;
        //    }
        //}
        #endregion

        // Getters and Setters from the web server class
        // minus the public virtual, ditching the useless data, part of the bug discussed.
        public decimal ENTRYNUMBER { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string ELEMENT { get; set; }
        public string ELEMENTTWO { get; set; }
        public decimal GENERATION { get; set; }

        public virtual ELEMENT ELEMENT1 { get; set; }
        public virtual ELEMENT ELEMENT2 { get; set; }
        public virtual GENERATION GENERATION1 { get; set; }
    }
}
