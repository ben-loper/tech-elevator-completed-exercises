using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int initialNumberOfRacoons = 3;
            int racoonsThatWentHomeToEatDinner = 2;
            int numberOfRemaingRacoons = initialNumberOfRacoons - racoonsThatWentHomeToEatDinner;


            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int numberOfLessBeesThanFlowers = numberOfFlowers - numberOfBees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int initialNumberOfPigeons = 1;
            int numberOfAdditionalPigeons = 1;
            int totalNumberOfPigeonsEating = initialNumberOfPigeons + numberOfAdditionalPigeons;


            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int initialNumberOfOwls = 3;
            int numberOfJoiningOwls = 2;
            int totalNumberOfOwls = initialNumberOfOwls + numberOfJoiningOwls;


            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int initialNumberOfBeaversWorking = 2;
            int numberOfBeaversThatWentSwimming = 1;
            int remainingNumberOfBeaversWorking = initialNumberOfBeaversWorking - numberOfBeaversThatWentSwimming;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int initialNumberOfToucans = 2;
            int numberOfToucansJoiningInitialToucans = 1;
            int totalNumberOfToucans = initialNumberOfToucans + numberOfToucansJoiningInitialToucans;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrels = 4;
            int numberOfNuts = 2;
            int numberOfHowManyMoreSquirrelsThanNuts = numberOfSquirrels - numberOfNuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal valueOfQuarter = .25M;
            decimal valueOfDime = .1M;
            decimal valueOfNickels = .05M;
            int numberOfQuarters = 1;
            int numberOfDimes = 1;
            int numberOfNickels = 2;

            decimal totalAmountOfMoney = (valueOfQuarter * numberOfQuarters) + (valueOfDime * numberOfDimes) + (valueOfNickels * numberOfNickels);

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int numberOfMrsBriersFirstGradeClassMuffins = 18;
            int numberOfMrsMacAdamsClassMuffins = 20;
            int numberOfMrsFlannerysMuffins = 17;

            int totalNumberOfMrsHiltsFavoriteFirstGradeClassTotalMuffinsCountCombined = numberOfMrsBriersFirstGradeClassMuffins + numberOfMrsMacAdamsClassMuffins + numberOfMrsFlannerysMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal costOfYoyo = .24M;
            decimal costOfWhistle = .14M;
            decimal totalSpentOnToys = costOfWhistle + costOfYoyo;


            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int numberOfLargeMarshmallows = 8;
            int numberOfMiniMarshmallows = 10;
            int totalNumberOfLargeAndMiniMarshmallows = numberOfLargeMarshmallows + numberOfMiniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowAtMrsHiltsHouse = 29;
            int inchesOfSnowAtBrecknockElementarySchool = 17;
            int numberOfHowMuchMoreSnowFellAtMrsHiltsHouseThanAtBrecknockElementarySchool = inchesOfSnowAtMrsHiltsHouse - inchesOfSnowAtBrecknockElementarySchool;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal amountOfMoneyMrsHiltHadInitially = 10.0M;
            decimal costForToyTruck = 3.0M;
            decimal costForPencilCase = 2.0M;

            decimal amountOfMoneyMrsHiltHasAfterPurchase = amountOfMoneyMrsHiltHadInitially - costForToyTruck - costForPencilCase;



            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int intialNumberOfMarblesInCollection = 16;
            int numberOfMarblesLost = 7;
            int numberOfRemainingMarbles = intialNumberOfMarblesInCollection - numberOfMarblesLost;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int currentNumberOfSeashells = 19;
            int numberOfTotaRequiredSeashells = 25;
            int numberOfMoreSeashellsNeeded = numberOfTotaRequiredSeashells - currentNumberOfSeashells;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalNumberOfBalloons = 17;
            int numberOfRedBalloons = 8;
            int numberOfGreenBallons = totalNumberOfBalloons - numberOfRedBalloons;


            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int initialNumberOfBooks = 38;
            int numberOfMoreBooks = 10;
            int totalNumberOfBooks = initialNumberOfBooks + numberOfMoreBooks;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            byte numberOfLegsOnBees = 6;
            int totalNumberOfBees = 8;
            int totalNumberOfLegs = totalNumberOfBees * (int)(numberOfLegsOnBees);



            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal costOfIceCreamCoan = .99M;
            int numberOfIceCreamCoans = 2;

            decimal totalCostOfIceCreamCones = costOfIceCreamCoan * numberOfIceCreamCoans;


            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int totalNumberOfRequiredRocks = 125;
            int numberOfCurrentRocks = 64;
            int numberOfMoreRocksNeeded = totalNumberOfRequiredRocks - numberOfCurrentRocks;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int initialNumberOfMarbles = 38;
            int numberOfMarblesMrsHiltLost = 15;
            int numberOfMarblesLeft = initialNumberOfMarbles - numberOfMarblesMrsHiltLost;


            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int numberOfMilesConcertIsAway = 78;
            int numberOfMilesTravelled = 32;
            int numberOfMilesLeft = numberOfMilesConcertIsAway - numberOfMilesTravelled;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int numberOfMinutesShovelingSnowOnSaturday = 90;
            int numberOfMinutesShovelingSnowOSaturdayAfternoon = 45;
            int totalTimeShovelingInMinutes = numberOfMinutesShovelingSnowOnSaturday - numberOfMinutesShovelingSnowOSaturdayAfternoon;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int numberOfHotDogsBought = 6;
            decimal costOfOneHotDog = .5M;
            decimal totalCostForHotDogs = numberOfHotDogsBought * costOfOneHotDog;


            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            int totalAmountMrsHiltHasInCents = 50;
            int costOfAPencilInCents = 7;
            int totalNumberOfPencilsMrsHiltCanBuy = totalAmountMrsHiltHasInCents / costOfAPencilInCents;



            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalNumberOfButterflies = 33;
            int numberOfOrangeButterflies = 20;
            int numberOfRedButterflies = totalNumberOfButterflies - numberOfOrangeButterflies;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal amountOfMoneyGiven = 1.0M;
            decimal costOfCandy = .54M;
            decimal amountOfMoneyGivenBack = amountOfMoneyGiven - costOfCandy;



            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int initialAmountOfTrees = 13;
            int numberOfPlantedTrees = 12;
            int totalNumberOfTrees = initialAmountOfTrees + numberOfPlantedTrees;

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int numberOfHoursInADay = 24;
            int numberOfDaysUntilSeeingGrandma = 2;
            int numberOfHoursUntilSeeingGrandma = numberOfHoursInADay * numberOfDaysUntilSeeingGrandma;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int desiredNumberOfPiecesOfGum = 5;
            int totalNumberOfPiecesOfGumNeeded = numberOfCousins * desiredNumberOfPiecesOfGum;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal amountOfMoneyDanInitiallyHas = 3.0M;
            decimal costOfCandyBar = 1.0M;
            decimal remaingAmountOfMoneyAfterPurchase = amountOfMoneyDanInitiallyHas - costOfCandyBar;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numberOfBoats = 5;
            int numberOfPeopleOnEachBoat = 3;
            int totalNumberOfPeopleOnBoatsInLake = numberOfBoats * numberOfPeopleOnEachBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int initialNumberOfLegos = 300;
            int numberOfLegosLost = 57;
            int numberOfRemainingLegos = initialNumberOfLegos - numberOfLegosLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int numberOfMuffinsBaked = 35;
            int desiredNumberOfMuffins = 83;
            int numberOfMuffinsThatNeedBaking = desiredNumberOfMuffins - numberOfMuffinsBaked;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int numberOfCrayonsWillyHas = 1400;
            int numberOfCrayonsLucyHas = 290;
            int numberOfHowManyMoreWillyHasThanLucy = numberOfCrayonsWillyHas - numberOfCrayonsLucyHas;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numberOfStickersOnPage = 10;
            int numberOfPagesOfStickers = 22;
            int totalNumberOfStickers = numberOfStickersOnPage * numberOfPagesOfStickers;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalNumberOfCupcakes = 96;
            int numberOfChildren = 8;
            int numberOfCupcakesEachChildWillGet = totalNumberOfCupcakes / numberOfChildren;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int totalNumberOfGingerBreadCookies = 47;
            int numberOfGingerBreadCookiesEachJarCanHold = 6;
            int numberOfCookiesNotPlacedInJar = totalNumberOfGingerBreadCookies % numberOfGingerBreadCookiesEachJarCanHold;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int totalNumberOfCroissants = 59;
            int numberNeighbors = 8;
            int numberOfCroissantsLeftOver = totalNumberOfCroissants % numberNeighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int numberOfCookiesThatCanBePlaceOnTray = 12;
            int totalNumberOfOatmealCookies = 276;
            int numberOfOatmealCookieTrays = totalNumberOfOatmealCookies / numberOfCookiesThatCanBePlaceOnTray;


            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalNumberOfPretzels = 480;
            int numberOfPretzelsInOneServing = 12;
            int totalNumberOfServings = totalNumberOfPretzels / numberOfPretzelsInOneServing;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalNumberOfLemonCupcakes = 51;
            int numberOfLemonCupcakesInBox = 3;
            int totalNumberOfBoxesOfLemonCupcakesGivenAway = totalNumberOfLemonCupcakes / numberOfLemonCupcakesInBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totalNumberOfCarrotSticks = 74;
            int numberOfPeopleServed = 12;
            int numberOfCarrotsLeftOver = totalNumberOfCarrotSticks % numberOfPeopleServed;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalNumberOfTeddyBears = 98;
            int numberOfTeddyBearPerShelf = 7;
            int totalNumberOfFullShelves = totalNumberOfTeddyBears / numberOfTeddyBearPerShelf;


            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalNumberOfPictures = 480;
            int numberOfPicturesAnAlbumCanHold = 20;
            int totalNumberOfAlbumsNeeded = totalNumberOfPictures / numberOfPicturesAnAlbumCanHold;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalNumberOfTradingCards = 94;
            int numberOfCardsOneBoxCanHold = 8;
            int numberOfFullBoxes = totalNumberOfTradingCards / numberOfCardsOneBoxCanHold;
            int numberOfCardsLeftAfterFillingBoxes = totalNumberOfTradingCards - totalNumberOfTradingCards / numberOfCardsOneBoxCanHold;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalNumberOfBooksSusiesFatherHas = 210;
            int NumberOfRepaireShelves= 10;
            int numberOfBooksOnEachShelve = totalNumberOfBooksSusiesFatherHas / NumberOfRepaireShelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numberOfCroissants = 17;
            int numberOfGuests = 7;
            int numberOfBooksEquallySharedForEachGuest = numberOfCroissants / numberOfGuests;

            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string firstName = "Ben";
            char middileInitial = 'P';
            String lastName = "Loper";

            string fullName = lastName + ", " + middileInitial + " " + firstName;
            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

        }
    }
}
