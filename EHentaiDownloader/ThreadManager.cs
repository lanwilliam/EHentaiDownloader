using Helios.Concurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EHentaiDownloader
{
    //public class ThreadManager
    //{
    //    public static List<DItem> list= new List<DItem>();
    //    public static void AddTask(DItem item)
    //    {
    //        list.Add(item);
    //        ThreadPool.QueueUserWorkItem(new WaitCallback(item.Run), list.Count);
    //    }

    //    public static void ReStart(DItem item)
    //    {
    //        ThreadPool.QueueUserWorkItem(new WaitCallback(item.Run), list.Count);
    //    }
        

    //    public static List<DItem> GetFinishedList()
    //    {
    //        List<DItem> rlist = new List<DItem>();
    //        foreach(DItem item in list)
    //        {
    //            if(item.Status.Equals("finished"))
    //            {
    //                rlist.Add(item);
                    
    //            }
    //        }
    //        foreach(DItem item in rlist)
    //        {
    //            list.Remove(item);
    //        }
    //        return rlist;
    //    }

    //    public static List<DItem> GetErrorList()
    //    {
    //        List<DItem> rlist = new List<DItem>();
    //        foreach (DItem item in list)
    //        {
    //            if (item.Status.Equals("Error"))
    //            {
    //                rlist.Add(item);

    //            }
    //        }
    //        foreach (DItem item in rlist)
    //        {
    //            list.Remove(item);
    //        }
    //        return rlist;
    //    }

    //    public static void StopAll()
    //    {
            
    //    }
    //}

    public class ThreadManager
    {
        public static List<DItem> list = new List<DItem>();

        private static DedicatedThreadPool threadPool = new Helios.Concurrency.DedicatedThreadPool(
        new DedicatedThreadPoolSettings(10));

        private static int index = 1;

        public static void AddTask(DItem item)
        {
            list.Add(item);
            item.SetNo(index);
            index++;
            threadPool.QueueUserWorkItem(() => { item.Run(1); });
        }

        public static void FlushNo()
        {
            index = 1;
            foreach(DItem item in list)
            {
                item.SetNo(index);
                index++;
            }
        }

        public static void ReStart(DItem item)
        {
            threadPool.QueueUserWorkItem(() => { item.Run(1); });
            
        }

        public static void Remove(DItem item)
        {
            list.Remove(item);
        }


        public static List<DItem> GetFinishedList()
        {
            List<DItem> rlist = new List<DItem>();
            foreach (DItem item in list)
            {
                if (item.Status.Equals("finished"))
                {
                    rlist.Add(item);

                }
            }
            foreach (DItem item in rlist)
            {
                list.Remove(item);
            }
            return rlist;
        }

        public static List<DItem> GetErrorList()
        {
            List<DItem> rlist = new List<DItem>();
            foreach (DItem item in list)
            {
                if (item.Status.Equals("Error"))
                {
                    rlist.Add(item);

                }
            }
            foreach (DItem item in rlist)
            {
                list.Remove(item);
            }
            return rlist;
        }
        public static List<DItem> GetErrorList2()
        {
            List<DItem> rlist = new List<DItem>();
            foreach (DItem item in list)
            {
                if (item.Status.Equals("Error"))
                {
                    rlist.Add(item);

                }
            }
            return rlist;
        }

        public static List<DItem> GetNotFinished()
        {
            List<DItem> rlist = new List<DItem>();
            foreach (DItem item in list)
            {
                if (!item.Status.Equals("finished"))
                {
                    rlist.Add(item);

                }
            }
            return rlist;
        }

        public static void StopAll()
        {

        }
    }
}
