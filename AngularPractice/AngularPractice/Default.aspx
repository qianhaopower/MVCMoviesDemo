<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AngularPractice._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
     <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.3.14/angular.min.js"></script>
     <script src="Scripts/Application/App.js" type="text/javascript"></script>


<%--    <div ng-app ng-init="qty=1;cost=2">
  <b>Invoice:</b>
  <div>
    Quantity: <input type="number" min="0" ng-model="qty">
  </div>
  <div>
    Costs: <input type="number" min="0" ng-model="cost">
  </div>
  <div>
    <b>Total:</b> {{qty * cost | currency}}
  </div>
</div>--%>


<%--    <div ng-app="invoice1" ng-controller="InvoiceController as invoice">
  <b>Invoice:</b>
  <div>
    Quantity: <input type="number" min="0" ng-model="invoice.qty" required >
  </div>
  <div>
    Costs: <input type="number" min="0" ng-model="invoice.cost" required >
    <select ng-model="invoice.inCurr">
      <option ng-repeat="c in invoice.currencies">{{c}}</option>
    </select>
  </div>
  <div>
    <b>Total:</b>
    <span ng-repeat="c in invoice.currencies">
      {{invoice.total(c) | currency:c}} <br/>
    </span>
    <button class="btn" ng-click="invoice.pay()">Pay</button>
  </div>
</div>--%>



<%--    <div ng-app="invoice2" ng-controller="InvoiceController as invoice">
  <b>Invoice:</b>
  <div>
    Quantity: <input type="number" min="0" ng-model="invoice.qty" required >
  </div>
  <div>
    Costs: <input type="number" min="0" ng-model="invoice.cost" required >
    <select ng-model="invoice.inCurr">
      <option ng-repeat="c in invoice.currencies">{{c}}</option>
    </select>
  </div>
  <div>
    <b>Total:</b>
    <span ng-repeat="c in invoice.currencies">
      {{invoice.total(c) | currency:c}}
    </span>
    <button class="btn" ng-click="invoice.pay()">Pay</button>
  </div>
</div>--%>

<%--    <div ng-app="invoice3" ng-controller="InvoiceController as invoice">
  <b>Invoice:</b>
  <div>
    Quantity: <input type="number" min="0" ng-model="invoice.qty" required >
  </div>
  <div>
    Costs: <input type="number" min="0" ng-model="invoice.cost" required >
    <select ng-model="invoice.inCurr">
      <option ng-repeat="c in invoice.currencies">{{c}}</option>
    </select>
  </div>
  <div>
    <b>Total:</b>
    <span ng-repeat="c in invoice.currencies">
      {{invoice.total(c) | currency:c}}
    </span>
    <button class="btn" ng-click="invoice.pay()">Pay</button>
  </div>
</div>--%>


<%--    <div ng-app="spicyApp1" ng-controller="SpicyController">
        <input ng-model="CustomSpice" />
 <button type='button' ng-click="spicy('chili')">Chili</button>
 <button  type='button' ng-click="spicy(CustomSpice)">Custom spice</button>
 <p>The food is {{spice}} spicy!</p>
</div>--%>


<%--    <div   ng-app="scopeInheritance" class="spicy">
  <div ng-controller="MainController">
    <p>Good {{timeOfDay}}, {{name}}!</p>

    <div ng-controller="ChildController">
      <p>Good {{timeOfDay}}, {{name}}!</p>

      <div ng-controller="GrandChildController">
        <p>Good {{timeOfDay}}, {{name}}!</p>
      </div>
    </div>
  </div>
</div>--%>



<%--    <div  ng-app="myServiceModule" id="simple" ng-controller="MyController">
  <p>Let's try this simple notify service, injected into the controller...</p>
  <input ng-init="message='test'" ng-model="message" >
  <button  ng-click="callNotify(message);">NOTIFY</button>
  <p>(you have to click 3 times to see an alert)</p>
</div>--%>


<%--    <div  ng-app="scopeExample" class="show-scope-demo">
  <div ng-controller="GreetController">
    Hello {{name}}!
  </div>
  <div  ng-controller="ListController">
    <ol>
      <li ng-repeat="name in names">{{name}} from {{department}}</li>
    </ol>
  </div>
</div>--%>


<%--    <div ng-app="expressionExample" ng-controller="ExampleController" class="expressions">
  Expression:
  <input type='text' ng-model="expr" size="80"/>
  <button type='button' ng-click="addExp(expr)">Evaluate</button>
  <ul>
   <li ng-repeat="expr in exprs track by $index">
     [ <a href="" ng-click="removeExp($index)">X</a> ]
     <tt>{{expr}}</tt> => <span ng-bind="$parent.$eval(expr)"></span>
    </li>
  </ul>
</div>--%>


<%--    <div  ng-app="expressionExample" class="example2" ng-controller="ExampleController">
  Name: <input ng-model="name" type="text"/>
  <button type='button' ng-click="greet()">Greet</button>
  <button type='button' ng-click="window.alert('Should not see me')">Won't greet</button>
</div>--%>


 <%--   <div ng-app="eventExampleApp" ng-controller="EventController">
  <button type='button' ng-click="clickMe($event)">Event</button>
  <p><code>$event</code>: <pre> {{$event | json}}</pre></p>
  <p><code>clickEvent</code>: <pre>{{clickEvent | json}}</pre></p>
</div>--%>


<%--<div ng-app ="FilterInControllerModule" ng-controller="FilterController as ctrl">
  <div>
    All entries:
    <span ng-repeat="entry in ctrl.array">{{entry.name}} </span>
  </div>
  <div>
    Entries that contain an "a":
    <span ng-repeat="entry in ctrl.filteredArray">{{entry.name}} </span>
  </div>
</div>--%>


<%--    <div   ng-app ="myReverseFilterApp" ng-controller="MyController">
  <input ng-model="greeting" type="text"><br>
  No filter: {{greeting}}<br>
  Reverse: {{greeting|reverse}}<br>
  Reverse + uppercase: {{greeting|reverse:true}}<br>
</div>--%>

<%--    <div ng-app = "formExample" ng-controller="ExampleController">
  <form novalidate class="simple-form">
    Name: <input type="text" ng-model="user.name" /><br />
    E-mail: <input type="email" ng-model="user.email" /><br />
    Gender: <input type="radio" ng-model="user.gender" value="male" />male
    <input type="radio" ng-model="user.gender" value="female" />female<br />
    <input type="button" ng-click="reset()" value="Reset" />
    <input type="button" ng-click="update(user)" value="Save" />
  </form>
  <pre>form = {{user | json}}</pre>
  <pre>master = {{master | json}}</pre>
</div>--%>


  <%--  <div  ng-app = "formExample" ng-controller="ExampleController2">
  <form novalidate class="css-form">
    Name: <input type="text" ng-model="user.name" required /><br />
    E-mail: <input type="email" ng-model="user.email" required /><br />
    Gender: <input type="radio" ng-model="user.gender" value="male" />male
    <input type="radio" ng-model="user.gender" value="female" />female<br />
    <input type="button" ng-click="reset()" value="Reset" />
    <input type="button" ng-click="update(user)" value="Save" />
  </form>

         <pre>form = {{user | json}}</pre>
  <pre>master = {{master | json}}</pre>
</div>--%>

    <%--<div ng-app = "formExample2" ng-controller="ExampleController3">
  <form name="form" class="css-form" novalidate>
    Name:
    <input type="text" ng-model="user.name" name="uName" required="" />
    <br />
    <div ng-show="form.$submitted || form.uName.$touched">
      <div ng-show="form.uName.$error.required">Tell us your name.</div>
    </div>

    E-mail:
    <input type="email" ng-model="user.email" name="uEmail" required="" />
    <br />
    <div ng-show="form.$submitted || form.uEmail.$touched">
      <span ng-show="form.uEmail.$error.required">Tell us your email.</span>
      <span ng-show="form.uEmail.$error.email">This is not a valid email.</span>
    </div>

    Gender:
    <input type="radio" ng-model="user.gender" value="male" />male
    <input type="radio" ng-model="user.gender" value="female" />female
    <br />
    <input type="checkbox" ng-model="user.agree" name="userAgree" required="" />

    I agree:
    <input ng-show="user.agree" type="text" ng-model="user.agreeSign" required="" />
    <br />
    <div ng-show="form.$submitted || form.userAgree.$touched">
      <div ng-show="!user.agree || !user.agreeSign">Please agree and sign.</div>
    </div>

    <input type="button" ng-click="reset(form)" value="Reset" />
    <input type="button" ng-click="update(user)" value="Save" />
  </form>
</div>--%>


  <%--<div>
    Size (integer 0 - 10):
    <input type="number" ng-model="size" name="size"
           min="0" max="10" integer />{{size}}<br />
    <span ng-show="form.size.$error.integer">The value is not a valid integer!</span>
    <span ng-show="form.size.$error.min || form.size.$error.max">
      The value must be in range 0 to 10!</span>
  </div>

  <div>
    Username:
    <input type="text" ng-model="name" name="name" username />{{name}}<br />
    <span ng-show="form.name.$pending.username">Checking if this name is available...</span>
    <span ng-show="form.name.$error.username">This username is already taken!</span>
  </div>--%>
    
    <div ng-app = "drag">
    <span draggable>Drag ME</span>
     </div>

    
   

</asp:Content>

