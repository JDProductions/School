<!DOCTYPE html>
<html>

   <head>
   <!--
      New Perspectives on HTML and CSS
      Tutorial 6
      Case Problem 3

      WidgetMage
      Author: James DuBois
      Date:   4/14/2015

      Filename:         cssDemo.htm
      Supporting files: back.png, cssForms.css, modernizr-1.5.js,
                        rundemo.js, wm.css, wmlogo.png                      

   -->

      <meta charset="UTF-8" />
      <title>Whatever it doesnt matter</title>

      <script src="modernizr-1.5.js"></script>
      <script src="rundemo.js"></script>

      <link href="wm.css" rel="stylesheet" type="text/css" />
      <link href="cssforms.css" rel="stylesheet" type="text/css" />



   </head>


   <body>

      <header>
         <img src="wmlogo.png" alt="WidgetMage" />
         <nav class="horizontal">
            <ul>
               <li><a href="#">Home</a></li>
               <li><a href="#">Tutorials</a></li>
               <li><a href="#">Widgets</a></li>
               <li><a href="#">Forums</a></li>
               <li><a href="#">Demos</a></li>
            </ul>
         </nav>
      </header>

      <nav class="vertical">
         <ul>
            <li class="newgroup"><a href="#">Home</a></li>
            <li class="newgroup"><a href="IfStatements">If Statements</a></li>
            <li><a href="#">Buttons</a></li>
            <li><a href="#">Calendars</a></li>
            <li><a href="#">Cookies</a></li>
            <li><a href="#">Drag &amp; Drop</a></li>
            <li><a href="#">Image Tools</a></li>
            <li><a href="#">Icons</a></li>
            <li><a href="#">Layout Tools</a></li>
            <li><a href="#">List Boxes</a></li>
            <li><a href="#">Menus</a></li>
            <li><a href="#">Popups</a></li>
            <li><a href="#">Ribbons</a></li>
            <li><a href="#">Sliders</a></li>
            <li><a href="#">Spinners</a></li>
            <li><a href="#">Toolbars</a></li>
            <li><a href="#">Tooltips</a></li>
            <li><a href="#">Tree Views</a></li>
            <li class="newgroup"><a href="#">Tutorials</a></li>
            <li><a href="#">Tips &amp; Tricks</a></li>
            <li><a href="#">White Papers</a></li>
            <li><a href="#">User Forums</a></li>
            <li><a href="#">External Links</a></li>
            <li class="newgroup"><a href="#">Demonstrations</a></li>
            <li class="newgroup"><a href="#">Contact Us</a></li>
         </ul>
      </nav>

      <section>
     <h1>PHP W3</h1>
                  <p>
                  <?php
         $txt = "Hello !";
         $x = 5;
         $y = 10.5;

         ?>
</p>

  </section>


</body>

</html>