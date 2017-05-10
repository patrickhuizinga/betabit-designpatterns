using System;

namespace BetaBit.DesignPatterns
{
    public abstract class PlanetType
    {
        private PlanetType()
        {
        }

        public abstract double HardSciencyStuff(DateTime time);


        #region Mercury

        public static PlanetType Mercury = new MercuryImpl();

        private sealed class MercuryImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                // don't forget the effects of relativity!
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Venus

        public static PlanetType Venus = new VenusImpl();

        private sealed class VenusImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Earth

        public static PlanetType Earth = new EarthImpl();

        private sealed class EarthImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Mars

        public static PlanetType Mars = new MarsImpl();

        private sealed class MarsImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Jupiter

        public static PlanetType Jupiter = new JupiterImpl();

        private sealed class JupiterImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Saturn

        public static PlanetType Saturn = new SaturnImpl();

        private sealed class SaturnImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Uranus

        public static PlanetType Uranus = new UranusImpl();

        private sealed class UranusImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion


        #region Neptune

        public static PlanetType Neptune = new NeptuneImpl();

        private sealed class NeptuneImpl : PlanetType
        {
            public override double HardSciencyStuff(DateTime time)
            {
                return 42; // todo replace with dazzling formula
            }
        }

        #endregion
    }
}
