using System;
using System.Text;
using System.Collections;

class Aggregator {
    private List<int> ? _list = null;

    private Predicate<int> ? _checkerPredicate = null;
    private Func<int, int, int> ? _aggregateFunc = null;

    public Aggregator(List<int> list, Predicate<int> checkerPredicate, Func<int, int, int> aggregateFunc) {
        this._list = list;
        this._checkerPredicate = checkerPredicate;
        this._aggregateFunc = aggregateFunc;
    }

    public int Run(int startValue) {
        const int Zero = 0;
        if (null == this._list) return Zero;
        if (null == this._checkerPredicate) return Zero;
        if (null == this._aggregateFunc) return Zero;

        int result = startValue;
        foreach (int element in this._list) {
            bool condition = this._checkerPredicate(element);
            if (condition) result = this._aggregateFunc(result, element);
        }
        return result;
    }
}

class ProgramMain {
    static void Main() {
        List <int> numbersList = new List <int> () { 15, 27, -8, -14, -45, 19, 100, 350 };

        int sumAllElements = new Aggregator(numbersList, x => true, (result, element) => result + element).Run(0);
        Console.WriteLine("Sum All Elements: " + sumAllElements);

        int sumNegativeElements = new Aggregator(numbersList, x => x < 0, (result, element) => result + element).Run(0);
        Console.WriteLine("Sum Negative Elements: " + sumNegativeElements);

        new Aggregator(numbersList, x => true, (result, element) => {
            Console.WriteLine("Element: " + element);
            return result;
        }).Run(0);
    }
}
