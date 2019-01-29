<HTML>
<HEAD>
<TITLE>Edit Customers</TITLE>
</HEAD>

<BODY bgcolor = #ADD8E6>
<H2><CENTER>Edit Customers
</CENTER></H2>
<FORM METHOD="post" action="editcustomer.php">
<P>
<HR>
<CENTER>

<?php

/* Connect to MySQL */ 
$link = new mysqli("services1.mcs.sdsmt.edu", "s7275982_f17", "goodol21", "db7275982_f17")or
  die("Unable to connect");
  
  if (!isset($_POST['id']))
{
   $id=0;
}
else
{
   $id = $_POST['id'];
}

/* left button*/
if (isset($_POST['left']))
{
   $query = "SELECT ID, Title, FirstName, MiddleName, LastName, Suffix FROM Customer WHERE ID < $id ORDER BY ID DESC";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $id       = $row[0];
       $title    = $row[1];
	   $fname    = $row[2];
	   $mname    = $row[3];
	   $lname    = $row[4];
	   $suffix   = $row[5];
    }
}
/*right button*/
elseif (isset($_POST['right']))
{
   $query = "SELECT ID, Title, FirstName, MiddleName, LastName, Suffix FROM Customer WHERE ID > $id ORDER BY ID ASC";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $id       = $row[0];
       $title    = $row[1];
	   $fname    = $row[2];
	   $mname    = $row[3];
	   $lname    = $row[4];
	   $suffix   = $row[5];
    }
}
/*add button*/
elseif (isset($_POST['add']))
{  $title = $_POST['title'];
   $fname = $_POST['fname'];
   $mname = $_POST['mname'];
   $lname = $_POST['lname'];
   $suffix= $_POST['suffix'];
   $query = "INSERT INTO Customer (ID, Title, FirstName, MiddleName, LastName, Suffix) VALUES('$id','$title','$fname','$mname','$lname','$suffix')";
   $res = $link->query($query);
   $message = "Record added";
}
/*delete button*/
elseif (isset($_POST['delete']))
{
   $query = "DELETE FROM Customer WHERE ID = $id";
   $res = $link->query($query);
   $message = "Record deleted";
}
/*update button*/
elseif (isset($_POST['update']))
{
   $title = $_POST['title'];
   $fname = $_POST['fname'];
   $mname = $_POST['mname'];
   $lname = $_POST['lname'];
   $suffix= $_POST['suffix'];
   $query = "UPDATE Customer SET Title='$title', FirstName='$fname', MiddleName='$mname', LastName='$lname', Suffix='$suffix' WHERE ID = $id";
   $res = $link->query($query);
   $message = "Record updated";
}
/*search button*/
elseif (isset($_POST['search']))
{
   $id = $_POST['id'];
   $query = "SELECT ID, Title, FirstName, MiddleName, LastName, Suffix FROM Customer WHERE ID LIKE '%$id%'";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $id       = $row[0];
       $title    = $row[1];
	   $fname    = $row[2];
	   $mname    = $row[3];
	   $lname    = $row[4];
	   $suffix   = $row[5];
   }
}


$title = trim($title);
$fname = trim($fname);
$mname = trim($mname);
$lname = trim($lname);
$suffix= trim($suffix);


$link->close();
?>

<BR> Customer ID:
<BR><INPUT TYPE="TEXT" NAME="id"
    <?php echo "VALUE=\"$id\"" ?>>
<BR>
<BR> Title:
<BR><INPUT TYPE="TEXT" NAME="title"
    <?php echo "VALUE=\"$title\"" ?>>
<BR>
<BR> First Name:
<BR><INPUT TYPE="TEXT" NAME="fname"
    <?php echo "VALUE=\"$fname\"" ?>>
<BR>
<BR> Middle Name:
<BR><INPUT TYPE="TEXT" NAME="mname"
    <?php echo "VALUE=\"$mname\"" ?>>
<BR>
<BR> Last Name:
<BR><INPUT TYPE="TEXT" NAME="lname"
    <?php echo "VALUE=\"$lname\"" ?>>
<BR>
<BR> Suffix:
<BR><INPUT TYPE="TEXT" NAME="suffix"
    <?php echo "VALUE=\"$suffix\"" ?>>
<BR>
<BR>

<INPUT TYPE="SUBMIT" NAME="left"     VALUE="<">
<INPUT TYPE="SUBMIT" NAME="right"    VALUE=">">
<INPUT TYPE="SUBMIT" NAME="search"   VALUE="Search">

<BR>
<BR>
<INPUT TYPE="SUBMIT" NAME="add"      VALUE="Add">
<INPUT TYPE="SUBMIT" NAME="update"   VALUE="Update">
<INPUT TYPE="SUBMIT" NAME="delete"   VALUE="Delete">

<?php
if (isset($_POST['message']))
{
   echo "<BR><BR>$message";
}

?>

<BR>
<BR>
<a href = Music.html>Return to Main Web Page</a>
</CENTER>
</FORM>
</BODY>
<HTML>