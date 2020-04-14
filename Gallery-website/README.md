Gallery-website
===============

Gallery Website

***
HTML, CSS JSP, JSTL, MVC2
***

![alt-link](https://raw.githubusercontent.com/jelenans/Gallery-website/master/New%20Picture1.bmp)

![alt-link](https://raw.githubusercontent.com/jelenans/Gallery-website/master/New%20Picture%203.bmp)

![alt-link](https://raw.githubusercontent.com/jelenans/Gallery-website/master/New%20Picture%202.bmp)

![alt-link](https://raw.githubusercontent.com/jelenans/Gallery-website/master/p4.bmp)

![alt-link](https://raw.githubusercontent.com/jelenans/Gallery-website/master/p5.bmp)

![alt-link](https://raw.githubusercontent.com/jelenans/Gallery-website/master/p6.bmp)


The application contains two modules: 

• Server and 

• user 

The server module is implemented as a network client-server application. The client part will be web applications (web application will connect to the server via socket). The server part is Java application with multiple threads (multi-threading). 
User module is a web application that uses a browser as the client application. User module is implemented in JSP and JSTL and servlet technology in MVC 2 template using apache-tomcat web server. 
Application logic implemented within the server module. User module is accessing the server module via a network connection. 
Enables two types of user applications: 

• curator- views, adds and changes data in the gallery 

• Visitor- can view the data in the gallery 

The application presents information about the gallery, art works and authors. 
Gallery describes the following information: 

• name (required) 

• address 

• year of establishment

Each author is described by the following data: 

• name (required) 

• surname (required) 

• date of birth 

• date of death 

• place of birth 

• place of death 

• biography 

• id (required) 

Every art work is described the following information: 

• title (required) 

• technique 

• style 

• date of creation 

• place of origin 

• description 

• id (required) 

• location (path of the file system to the photo gallery or sculpture, or to audio or video file 
of multimedia records)  

Works of art that are stored in the gallery can be: paintings, sculpture and multimedia records. Paintings and sculptures are specific works of art, and multimedia files can be videos and audios. 
Each image, in addition to the data that describe each piece of art, described and additional information: 

• width (optional) 

• height (optional) 

Each sculpture is in addition to the data that describe each piece of art, described and additional information: 

• width (optional) 

• height (optional) 

• length (required) 

Each multimedia clip, in addition to the data that describe each piece of art, described and additional information: 

• duration (optional) 

• format (required) 

To the registered curators system provides the following functionality: 

• adding information about the author 

• adding information about a work of art 

• edit information about the author 

• change to the work of art 

• delete data on the author 

• delete the data section 

• Finding work based on id's 

• finding the authors based on id's 

• Finding work on the basis of: title, technique, style, and the names and surnames 

• finding the authors on the basis of: name, style in which they are created his works in the gallery and 
techniques which are created his works in the gallery 

• Review all work 

• Review all authors


To the visitors system provides the following functionality: 

• Review all the information about the authors in the gallery 

• Overview of authors per directions 

• Review authors in technique 

• Review of work in the gallery 

• Review of work by authors 

• Review of work by directions 

• Review work on technique 


When entering data about a work of art, the curator can place the file associated with it (for example jpg file of a photo or sculpture, or audio or video file for a multimedia recording). In doing so, the file is placed in the dedicated folder on the server.

The list of registered curator is defined in a separate file. 

The application permanently stores data in files.  

Synchronized access to shared resources in the classes that implement the business logic of the application.
