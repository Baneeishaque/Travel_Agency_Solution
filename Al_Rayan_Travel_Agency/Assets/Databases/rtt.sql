SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`,
`send_money`.`id_client`,`collection`.benefit FROM `alrayan`.`collection`,`alrayan`.`send_money` where operation='Send' AND 
`send_money`.`id_send_money`=`collection`.`id_operation` AND `send_money`.`id_client`=1000;
