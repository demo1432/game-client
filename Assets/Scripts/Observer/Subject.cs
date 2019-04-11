
using System;
using System.Collections.Generic;

public class Subject
{

    private static Subject instance = new Subject();

    private Dictionary<int, List<IObserver>> observersMap = new Dictionary<int, List<IObserver>>();

    public static Subject getInstance()
    {
        return instance;
    }

    public void addObserver(int code, IObserver ob)
    {
        List<IObserver> obs = null;
        if (!observersMap.ContainsKey(code))
        {
            obs = new List<IObserver>();
            obs.Add(ob);
            observersMap.Add(code, obs);
            return;
        }

        obs = observersMap[code];
        if (!obs.Contains(ob))
        {
            obs.Add(ob);
        }
    }

    public void removeObserver(int code, IObserver ob)
    {
        if (!observersMap.ContainsKey(code))
        {
            return;
        }

        List<IObserver> obs = observersMap[code];
        if (obs.Contains(ob))
        {
            obs.Remove(ob);
        }
    }

    public void notify(int code, object data = null)
    {
        if (!observersMap.ContainsKey(code))
        {
            return;
        }

        List<IObserver> obs = observersMap[code];
        foreach (IObserver ob in obs) {
            ob.onNotify(code, data);
        }
    }

}
