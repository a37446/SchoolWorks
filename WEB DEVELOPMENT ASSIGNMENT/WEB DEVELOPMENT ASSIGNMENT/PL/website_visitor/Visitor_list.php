<?php
$visitor_array = Website_VisitorController::retrieve_visitors();
$output='<table class="visitor_table"> <tr> <th> ID Visitor </th> <th> Visited Pages </th> <th> Visit Start </th> <th> Visit End </th> </tr>';
for ($i=0;$i<count($visitor_array);$i++) {
            $output = $output . '<tr>';
            $output = $output . '<td>' . $visitor_array[$i]->getIdVisitor() . "</td>";
            $output = $output . '<td>' . $visitor_array[$i]->getvisited_page() . "</td>";
            $output = $output . '<td>' . $visitor_array[$i]->getVisit_start() . "</td>";
            $output = $output . '<td>' . $visitor_array[$i]->getVisit_end() . "</td>";
            $output = $output . '</tr>';
}
$output= $output . "</table>";
echo $output;
?>
