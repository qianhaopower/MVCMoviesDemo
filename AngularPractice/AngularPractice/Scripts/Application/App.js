angular.module('invoice1', [])
.controller('InvoiceController', function () {
    this.qty = 1;
    this.cost = 2;
    this.inCurr = 'EUR';
    this.currencies = ['USD', 'EUR', 'CNY'];
    this.usdToForeignRates = {
        USD: 1,
        EUR: 0.74,
        CNY: 6.09
    };

    this.total = function total(outCurr) {
        return this.convertCurrency(this.qty * this.cost, this.inCurr, outCurr);
    };
    this.convertCurrency = function convertCurrency(amount, inCurr, outCurr) {
        return amount * this.usdToForeignRates[outCurr] / this.usdToForeignRates[inCurr];
    };
    this.pay = function pay() {
        window.alert("Thanks!");
    };
});



angular.module('finance2', [])
.factory('currencyConverter', function () {
    var currencies = ['USD', 'EUR', 'CNY'];
    var usdToForeignRates = {
        USD: 1,
        EUR: 0.74,
        CNY: 6.09
    };
    var convert = function (amount, inCurr, outCurr) {
        return amount * usdToForeignRates[outCurr] / usdToForeignRates[inCurr];
    };

    return {
        currencies: currencies,
        convert: convert
    };
});

angular.module('invoice2', ['finance2'])
.controller('InvoiceController', ['currencyConverter', function (currencyConverter) {
    this.qty = 1;
    this.cost = 2;
    this.inCurr = 'EUR';
    this.currencies = currencyConverter.currencies;

    this.total = function total(outCurr) {
        return currencyConverter.convert(this.qty * this.cost, this.inCurr, outCurr);
    };
    this.pay = function pay() {
        window.alert("Thanks!");
    };
}]);

angular.module('invoice3', ['finance3'])
.controller('InvoiceController', ['currencyConverter', function (currencyConverter) {
    this.qty = 1;
    this.cost = 2;
    this.inCurr = 'EUR';
    this.currencies = currencyConverter.currencies;

    this.total = function total(outCurr) {
        return currencyConverter.convert(this.qty * this.cost, this.inCurr, outCurr);
    };
    this.pay = function pay() {
        window.alert("Thanks!");
    };
}]);
angular.module('finance3', [])
.factory('currencyConverter', ['$http', function ($http) {
    var YAHOO_FINANCE_URL_PATTERN =
          '//query.yahooapis.com/v1/public/yql?q=select * from ' +
          'yahoo.finance.xchange where pair in ("PAIRS")&format=json&' +
          'env=store://datatables.org/alltableswithkeys&callback=JSON_CALLBACK';
    var currencies = ['USD', 'EUR', 'CNY'];
    var usdToForeignRates = {};

    var convert = function (amount, inCurr, outCurr) {
        return amount * usdToForeignRates[outCurr] / usdToForeignRates[inCurr];
    };

    var refresh = function () {
        var url = YAHOO_FINANCE_URL_PATTERN.
                   replace('PAIRS', 'USD' + currencies.join('","USD'));
        return $http.jsonp(url).success(function (data) {
            var newUsdToForeignRates = {};
            angular.forEach(data.query.results.rate, function (rate) {
                var currency = rate.id.substring(3, 6);
                newUsdToForeignRates[currency] = window.parseFloat(rate.Rate);
            });
            usdToForeignRates = newUsdToForeignRates;
        });
    };

    refresh();

    return {
        currencies: currencies,
        convert: convert,
        refresh: refresh
    };
}]);



var myApp = angular.module('spicyApp1', []);

myApp.controller('SpicyController', ['$scope', function ($scope) {
    $scope.spice = 'very';
    $scope.CustomSpice = "wasabi";

    $scope.chiliSpicy = function () {
        $scope.spice = 'chili';
    };

    $scope.jalapenoSpicy = function () {
        $scope.spice = 'jalapeño';
    };

    $scope.spicy = function (spice) {
        $scope.spice = spice;
    }
}]);



var myApp = angular.module('scopeInheritance', []);
myApp.controller('MainController', ['$scope', function ($scope) {
    $scope.timeOfDay = 'morning';
    $scope.name = 'Nikki';
}]);
myApp.controller('ChildController', ['$scope', function ($scope) {
    $scope.name = 'Mattie';
}]);
myApp.controller('GrandChildController', ['$scope', function ($scope) {
    $scope.timeOfDay = 'evening';
    $scope.name = 'Gingerbread Baby';
}]);


angular.
module('myServiceModule', []).
 controller('MyController', ['$scope', 'notify', function ($scope, notify) {
     $scope.callNotify = function (msg) {
         notify(msg);
     };
 }]).
factory('notify', ['$window', function (win) {
    var msgs = [];
    return function (msg) {
        msgs.push(msg);
        if (msgs.length == 3) {
            win.alert(msgs.join("\n"));
            msgs = [];
        }
    };
}]);

angular.module('scopeExample', [])
.controller('GreetController', ['$scope', '$rootScope', function ($scope, $rootScope) {
    $scope.name = 'World';
    $rootScope.department = 'Angular';
}])
.controller('ListController', ['$scope', function ($scope) {
    $scope.names = ['Igor', 'Misko', 'Vojta'];

}]);


angular.module('expressionExample', [])
.controller('ExampleController', ['$scope', function ($scope) {
    var exprs = $scope.exprs = [];
    $scope.expr = '3*10|currency';
    $scope.addExp = function (expr) {
        exprs.push(expr);
    };

    $scope.removeExp = function (index) {
        exprs.splice(index, 1);
    };
}]);

angular.module('expressionExample', [])
.controller('ExampleController', ['$window', '$scope', function ($window, $scope) {
    $scope.name = 'World';

    $scope.greet = function () {
        $window.alert('Hello ' + $scope.name);
    };
}]);

angular.module('eventExampleApp', []).
controller('EventController', ['$scope', function ($scope) {
    /*
     * expose the event object to the scope
     */
    $scope.clickMe = function (clickEvent) {
        $scope.clickEvent = simpleKeys(clickEvent);
        console.log(clickEvent);
    };

    /*
     * return a copy of an object with only non-object keys
     * we need this to avoid circular references
     */
    function simpleKeys(original) {
        return Object.keys(original).reduce(function (obj, key) {
            obj[key] = typeof original[key] === 'object' ? '{ ... }' : original[key];
            return obj;
        }, {});
    }


}]);

//??????????????? who defined fialterFitler?
angular.module('FilterInControllerModule', []).
controller('FilterController', ['filterFilter', function (fialterFilter) {
    this.array = [
      { name: 'Tobias' },
      { name: 'Jeff' },
      { name: 'Brian' },
      { name: 'Igor' },
      { name: 'James' },
      { name: 'Brad' }
    ];
    this.filteredArray = fialterFilter(this.array, 'a');
}]);


angular.module('myReverseFilterApp', [])
.filter('reverse', function () {
    return function (input, uppercase) {
        input = input || '';
        var out = "";
        for (var i = 0; i < input.length; i++) {
            out = input.charAt(i) + out;
        }
        // conditional based on optional argument
        if (uppercase) {
            out = out.toUpperCase();
        }
        return out;
    };
})
.controller('MyController', ['$scope', function ($scope) {
    $scope.greeting = 'hello';
}]);

angular.module('formExample', [])
    .controller('ExampleController', ['$scope', function ($scope) {
        $scope.master = {};

        $scope.update = function (user) {
            $scope.master = angular.copy(user);
        };

        $scope.reset = function () {
            $scope.user = angular.copy($scope.master);
        };

        $scope.reset();
    }]);


//css color is not showing?
angular.module('formExample', [])
   .controller('ExampleController2', ['$scope', function ($scope) {
       $scope.master = {};

       $scope.update = function (user) {
           $scope.master = angular.copy(user);
       };

       $scope.reset = function () {
           $scope.user = angular.copy($scope.master);
       };

       $scope.reset();
   }]);

angular.module('formExample2', [])
.controller('ExampleController3', ['$scope', function ($scope) {
    $scope.master = {};

    $scope.update = function (user) {
        $scope.master = angular.copy(user);
    };

    $scope.reset = function (form) {
        if (form) {
            form.$setPristine();
            form.$setUntouched();
        }
        $scope.user = angular.copy($scope.master);
    };

    $scope.reset();
}]);



//why the error message is not showing?
var app = angular.module('form-example1', []);

var INTEGER_REGEXP = /^\-?\d+$/;
app.directive('integer', function () {
    return {
        require: 'ngModel',
        link: function (scope, elm, attrs, ctrl) {
            ctrl.$validators.integer = function (modelValue, viewValue) {
                if (ctrl.$isEmpty(modelValue)) {
                    // consider empty models to be valid
                    return true;
                }

                if (INTEGER_REGEXP.test(viewValue)) {
                    // it is valid
                    return true;
                }

                // it is invalid
                return false;
            };
        }
    };
});

app.directive('username', function ($q, $timeout) {
    return {
        require: 'ngModel',
        link: function (scope, elm, attrs, ctrl) {
            var usernames = ['Jim', 'John', 'Jill', 'Jackie'];

            ctrl.$asyncValidators.username = function (modelValue, viewValue) {

                if (ctrl.$isEmpty(modelValue)) {
                    // consider empty model valid
                    return $q.when();
                }

                var def = $q.defer();

                $timeout(function () {
                    // Mock a delayed response
                    if (usernames.indexOf(modelValue) === -1) {
                        // The username is available
                        def.resolve();
                    } else {
                        def.reject();
                    }

                }, 2000);

                return def.promise;
            };
        }
    };
});



angular.module('drag', []).
directive('draggable', function ($document) {
    return function (scope, element, attr) {
        var startX = 0, startY = 0, x = 0, y = 0;
        element.css({
            position: 'relative',
            border: '1px solid red',
            backgroundColor: 'lightgrey',
            cursor: 'pointer',
            display: 'block',
            width: '65px'
        });
        element.on('mousedown', function (event) {
            // Prevent default dragging of selected content
            event.preventDefault();
            startX = event.screenX - x;
            startY = event.screenY - y;
            $document.on('mousemove', mousemove);
            $document.on('mouseup', mouseup);
        });

        function mousemove(event) {
            y = event.screenY - startY;
            x = event.screenX - startX;
            element.css({
                top: y + 'px',
                left: x + 'px'
            });
        }

        function mouseup() {
            $document.off('mousemove', mousemove);
            $document.off('mouseup', mouseup);
        }
    };
});

angular.module('docsSimpleDirective', [])
.controller('Controller', ['$scope', function ($scope) {
    $scope.customer = {
        name: 'Naomi',
        address: '1600 Amphitheatre'
    };
}])
.directive('myCustomer', function () {
    return {
        template: 'Name: {{customer.name}} Address: {{customer.address}}'
    };
});


angular.module('docsTemplateUrlDirective', [])
.controller('Controller', ['$scope', function ($scope) {
    $scope.customer = {
        name: 'Naomi',
        address: '1600 Amphitheatre'
    };
}])
.directive('myCustomer', function () {
    return {
        restrict: 'AEC',
        templateUrl: 'my-customer.html'
    };
});


// did not really understand, customerInfo is a Object?
angular.module('docsIsolateScopeDirective', [])
.controller('Controller', ['$scope', function ($scope) {
    $scope.naomia = { name: 'Naomi', address: '1600 Amphitheatre' };
    $scope.igor = { name: 'Igor', address: '123 Somewhere' };
}])
.directive('myCustomer', function () {
    return {
        restrict: 'E',
        scope: {
            customerInfo: '=info'
        },
        templateUrl: 'my-customer-iso.html'
    };
});


angular.module('docsTimeDirective', [])
.controller('Controller', ['$scope', function ($scope) {
    $scope.format = 'M/d/yy h:mm:ss a';
}])
.directive('myCurrentTime', ['$interval', 'dateFilter', function ($interval, dateFilter) {

    function link(scope, element, attrs) {
        var format,
            timeoutId;

        function updateTime() {
            element.text(dateFilter(new Date(), format));
        }

        scope.$watch(attrs.myCurrentTime, function (value) {
            format = value;
            updateTime();
        });

        element.on('$destroy', function () {
            $interval.cancel(timeoutId);
        });

        // start the UI update process; save the timeoutId for canceling
        timeoutId = $interval(function () {
            updateTime(); // update DOM
        }, 1000);
    }

    return {
        link: link
    };
}]);

angular.module('Animation', ["ngAnimate"]);
