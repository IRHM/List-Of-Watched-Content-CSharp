<?php
	error_reporting(0);
	$RandomString = $_GET['RandomString'];

	$Rand = $RandomString;

	$Dir = './imports';
	if ($_FILES["file"]["error"] == UPLOAD_ERR_OK) {
		$tmp_name = $_FILES["file"]["tmp_name"];
		move_uploaded_file($tmp_name, "./imports/import$Rand.sbond");
		echo "import$Rand.sbond"; // What c# program reads
	}
?>