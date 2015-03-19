﻿angular.module('invoice1', [])
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