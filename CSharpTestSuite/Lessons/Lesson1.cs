namespace CSharpTestSuite.Lessons
{
  // ReferenceAndNullableTypesLesson.cs
    public class Lesson1
    {
        public void RunLesson()
        {
            // # Reference Types
            // 1. Stage
            // ## Top-level Statements
            // Ահա C#-ում տարածված reference types-երի օրինակներ.

            // 1. Classes (դասեր):
            // Class-երը հիմնական reference type-երն են, որոնք օգտագործվում են օբյեկտներ ստեղծելու համար:

            /*
             * Error CS8803: Top-level statements must precede namespace and type declarations.
             * Սա նշանակում է, որ top-level statements-երը պետք է լինեն ֆայլի սկզբում՝ մինչեւ class կամ namespace-ի հայտարարումը։
             */

            // ❌ Սխալ կոդ՝ դասը հայտարարելուց հետո top-level statements կիրառելիս.
            // class Car
            // {
            //     public string Model { get; set; } = "Tesla";
            // }
            //
            // Car myCar = new Car(); // Այս տողը կհանգեցնի սխալին՝ top-level statements-երը պետք է լինեն ֆայլի սկզբում.
            // Console.WriteLine($"myCar: {myCar.Model}");

            // ✅ Ճիշտ կոդ՝ Top-level statements-ի ճիշտ կիրառմամբ.
            // Top-level statements-երը թույլ են տալիս գրել կոդ առանց Main մեթոդի կամ դասի,
            // բայց class-երը պետք է դրվեն ֆայլի վերջում կամ այլ ֆայլում.

            // Top-level statement:
            // Car myCar = new Car();
            // Console.WriteLine(myCar.Model); // Արդյունք՝ "Tesla"
            //
            // // Class-ի հայտարարումը՝ ֆայլի վերջում կամ այլ ֆայլում.
            // class Car
            // {
            //     public string Model { get; set; } = "Tesla";
            // }

            // 2. Stage: Value types և reference types տարբերությունները:

            /*
             * C#-ում string-ը համարվում է reference type, իսկ int, bool, float և այլ primitive տիպերը համարվում են value type:
             * Տարբերությունը կապված է նրանց պահեստավորման (stack կամ heap) և տվյալների փոխանցման մեխանիզմի հետ։
             */

            // string-ը reference type է, քանի որ դա class է, իսկ primitive types-երը՝ value type, և պահվում են stack-ում:

            // Primitive types (value types) օրինակներ՝
            // int, bool, float, char, byte, sbyte, short, ushort, long, ulong, double, decimal.

            // struct-երը և enum-երը նույնպես value types են, և դուք կարող եք ստեղծել ձեր սեփական struct-երը.

            // Value types կարող են նաև պահվել heap-ում boxing-ի միջոցով:

            int num = 42;           // Primitive type՝ պահվում է stack-ում:
            object obj = num;       // Boxing՝ primitive type-ը տեղափոխվում է heap։

            // Unboxing:
            int unboxedNum = (int)obj; // Unboxing՝ heap-ից վերադարձվում է stack։

            // Casting-ը՝

            /*
             * Casting-ը այն գործընթացն է, որով փոփոխականը մի տիպից վերածվում է մեկ այլ տիպի։
             * Կան երկու տեսակ casting՝
             * 1. Implicit (անուղղակի) casting՝ կատարվում է ավտոմատ, երբ տվյալների կորստի վտանգ չկա:
             * 2. Explicit (ուղղակի) casting՝ պահանջում է հստակ նշել տիպը։
             */

            double d = 9.78;
            int castedNum = (int)d; // Explicit casting, կորցնում ենք տասնորդական մասը:

            /*
             * C#-ում object տիպը բոլոր տիպերի հիմքն է և համարվում է base class բոլոր տիպերի համար։
             * Դուք կարող եք պահել ինչպես value types, այնպես էլ reference types՝ object-ում:
             */

            object value1 = 42;  // int արժեքը պահվում է որպես object:
            Console.WriteLine($"Type of value1: {value1.GetType()}");  // System.Int32

            // Object class մեթոդներ՝
            // Equals(object obj), GetHashCode(), GetType(), ToString(), MemberwiseClone(), Finalize():

            int number2 = 42;
            string str = number2.ToString();  // No casting needed, just calls ToString():
            Console.WriteLine($"str: {str}");  // Արդյունք՝ "42"
            Console.WriteLine($"Type of number: {number2.GetType()}");  // System.Int32



            /**********/
            // # Nullable տիպի հայտարարում

            /*
             * Nullable types-ը թույլ են տալիս, որ value type-երը (օրինակ՝ int, bool, float) կարողանան ընդունել null արժեք։
             * Սա հնարավոր չէ ըստ լռելյայնի, քանի որ value type-երը չեն կարող լինել null։
             * Հակառակ դեպքում, reference type-երը (օրինակ՝ string) լռելյայն կարող են ընդունել null:
             */

            // Nullable value type-երի օրինակներ:

            int? number = null;    // Nullable int
            bool? isAvailable = null;    // Nullable bool
            float? temperature = null;   // Nullable float

            /*
             * `Nullable<T>` երկարաձևը. Nullable<T>-ը այն դասն է, որը պատասխանատու է nullable արժեքներ պահելու համար։
             * Կարճաձևը `T?` պարզապես այս դասի ավելի հարմար ներկայացումն է։
             */

            Nullable<int> age = null;  // Նույնն է, ինչ `int?`, 'age'-ը կարող է լինել թիվ կամ null

            // Ստուգում ենք՝ արդյո՞ք age-ն ունի արժեք
            if (age.HasValue)
            {
             Console.WriteLine($"Age: {age}");
            }
            else
            {
             Console.WriteLine("Age is null");
            }

            /*
             * Ուշադրություն:
             * C#-ում reference types-երը (օրինակ՝ string, class, array) լռելյայն կարող են ընդունել null արժեքներ։ Այսպիսով, nullable
             * կոնցեպտը հատկապես կարևոր է value type-երի համար (օրինակ՝ int, bool), քանի որ նրանք չեն կարող լռելյայն ընդունել null:
             */

            string? name = null;  // Nullable reference type՝ C# 8.0-ից հետո
            string nonNullableName = "Alice";  // Non-nullable reference type
        }
    }

    // Class for Car
    public class Car
    {
        public string Model { get; set; } = "Tesla";
    }
}
