using System;
using System.Collections.Generic;
using System.Text;

namespace StudioOne {
    class Circle {

        private double radius;
        public Circle(double Radius) {


            radius = Radius;


        }

        public double getArea() {

            return Math.PI * radius * radius;

        }

        public double getCircumference() {

            return 2 * Math.PI * radius;

        }

        public double getDiameter() {

            return 2 * radius;

        }

    }
}
