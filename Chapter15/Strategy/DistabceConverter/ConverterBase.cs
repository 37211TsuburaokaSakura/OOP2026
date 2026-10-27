using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter;

//抽象クラス
public abstract class ConverterBase {

    public abstract bool IsMyUnit(string name);

    //メートルとの比率（この比率をかけるとメートルに変換できる）
    protected abstract double Ratio { get; }

    //距離の単位名（たとえば"メートル","フィート"など）
    public abstract string UnitName { get; }

    //メートルからの変換
    public double FromMeter(double Meter) => Meter / Ratio;

    //メートルへの変換
    public double ToMeter(double feet) => feet * Ratio;
}

