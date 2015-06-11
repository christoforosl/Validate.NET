 /// <summary>
/// Port of apache commons lang validate functionality
/// </summary>
public class Validate {

        private Validate() {

        }

        public static void isInRange(int value, int lowbound, int upperBound) {
            IsTrue(value >= lowbound && value <= upperBound, "Range Check failed!");
        }

        public static void isNotNull(object thing) {
            IsTrue(thing != null, "Null Check failed");
        }

        public static void isNotNull(object thing, string message, params object[] args) {
            IsTrue(thing != null, message, args);
        }


        public static void StringIsNotNullOrEmpty(string str, string message, params object[] args) {
            IsTrue(string.IsNullOrEmpty(str), message, args);
        }

        public static void IsTrue(bool expr) {
            IsTrue(expr, null);
        }
        
        public static void IsTrue(bool expr, string message, params object[] args) {

            string exceptionMessage = string.IsNullOrEmpty(message) ? "Runtime validation failed" : message;
            if (args != null && args.Length > 0) {
                exceptionMessage = String.Format(exceptionMessage, args );
            }
            if (!expr) throw new ValidationException(exceptionMessage);

        }

    }
