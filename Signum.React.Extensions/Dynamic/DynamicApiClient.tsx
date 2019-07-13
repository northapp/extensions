import * as React from 'react'
import { EntitySettings } from '@framework/Navigator'
import * as Navigator from '@framework/Navigator'
import { DynamicApiEntity, DynamicApiEval } from './Signum.Entities.Dynamic'
import { SearchControl, ValueSearchControlLine } from '@framework/Search'
import * as Finder from '@framework/Finder'
import * as Constructor from '@framework/Constructor'
import * as DynamicClientOptions from './DynamicClientOptions'

export function start(options: { routes: JSX.Element[] }) {
  Navigator.addSettings(new EntitySettings(DynamicApiEntity, w => import('./Api/DynamicApi')));
  Constructor.registerConstructor(DynamicApiEntity, () => DynamicApiEntity.New({ eval: DynamicApiEval.New() }));
  DynamicClientOptions.Options.onGetDynamicLineForPanel.push(ctx => <ValueSearchControlLine ctx={ctx} findOptions={{ queryName: DynamicApiEntity }} />);
  DynamicClientOptions.Options.onGetDynamicPanelSearch.push(search => ({
    queryName: DynamicApiEntity, filterOptions: [Finder.pinnedSearchFilterWithValue(DynamicApiEntity, search,
      t => t.entity(p => p.name),
      t => t.entity(p => p.eval!.script))
    ]
  }));
}
