SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`,
`receive_money`.`id_client`,`collection`.benefit FROM `alrayan`.`collection`,`alrayan`.`receive_money` where operation='Receive' AND 
`receive_money`.`id`=`collection`.`id_operation` AND `receive_money`.`id_client`=1000;

/*SELECT `receive_money`.`id`,
    `receive_money`.`date`,
    `receive_money`.`inr`,
    `receive_money`.`rate`,
    `receive_money`.`benefit`,
    `receive_money`.`deliver_aed`,
    `receive_money`.`id_client`,
    `receive_money`.`agency_rate`,
    `receive_money`.`actual_aed`
FROM `alrayan`.`receive_money`;